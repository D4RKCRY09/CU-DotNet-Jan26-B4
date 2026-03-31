using LayeredRepo.Model;
using LayeredRepo.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

internal class JsonStudentRepo : IStudentRepository
{
    private readonly string _filepath = "../../../students.json";
    private readonly JsonSerializerOptions _options = new JsonSerializerOptions
    {
        WriteIndented = true
    };

    public IEnumerable<Student> GetStudents()
    {
        if (!File.Exists(_filepath)) return Enumerable.Empty<Student>();

        try
        {
            string jsonString = File.ReadAllText(_filepath);
            if (string.IsNullOrWhiteSpace(jsonString)) return Enumerable.Empty<Student>();

            return JsonSerializer.Deserialize<List<Student>>(jsonString) ?? new List<Student>();
        }
        catch (JsonException)
        {
            // Handle cases where the JSON file might be corrupted
            return Enumerable.Empty<Student>();
        }
    }

    public void AddStudent(Student student)
    {
        var students = GetStudents().ToList();
        students.Add(student);
        SaveAll(students);
    }

    public void UpdateStudent(Student updatedStudent)
    {
        var students = GetStudents().ToList();
        int index = students.FindIndex(s => s.StudentId == updatedStudent.StudentId);

        if (index != -1)
        {
            students[index] = updatedStudent;
            SaveAll(students);
        }
    }

    public void DeleteStudent(Student deleteStudent)
    {
        var students = GetStudents().ToList();
        int initialCount = students.Count;

        students.RemoveAll(s => s.StudentId == deleteStudent.StudentId);

        if (students.Count < initialCount)
        {
            SaveAll(students);
        }
    }

    private void SaveAll(List<Student> students)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(students, _options);
            File.WriteAllText(_filepath, jsonString);
        }
        catch (IOException ex)
        {
            // Log or handle file access issues (e.g., file in use by another process)
            Console.WriteLine($"Error saving to file: {ex.Message}");
        }
    }
}