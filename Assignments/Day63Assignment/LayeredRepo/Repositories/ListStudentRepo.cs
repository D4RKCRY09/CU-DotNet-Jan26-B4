using LayeredRepo.Model;

namespace LayeredRepo.Repositories
{
    internal class ListStudentRepo : IStudentRepository
    {
        private static List<Student> _students = new List<Student>();

        public void AddStudent(Student student) => _students.Add(student);

        public void DeleteStudent(Student deleteStudent)
        {
            var students = GetStudents().ToList();
            int initialCount = students.Count;

            students.RemoveAll(s => s.StudentId == deleteStudent.StudentId);
        }

        public IEnumerable<Student> GetStudents() => _students;

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
    }
}
