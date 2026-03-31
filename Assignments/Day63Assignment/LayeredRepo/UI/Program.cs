using LayeredRepo.Services;
using LayeredRepo.Repositories;
using LayeredRepo.Model;
namespace LayeredRepo.UI
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your repo preference :- \n1.List\n2.JSON");

            int input = int.Parse(Console.ReadLine());

            IStudentServices service;
            if (input == 2) service = new StudentServices(new JsonStudentRepo());
            else service = new StudentServices(new ListStudentRepo());

            Console.WriteLine("Number of students you want to enter :-");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Student student = new Student();
                student.StudentId = i + 1;
                Console.WriteLine("Enter student name = ");
                student.Name = Console.ReadLine();
                Console.WriteLine("Enter student grades = ");
                student.Grades = int.Parse(Console.ReadLine());

                try
                {
                    service.AddStudent(student);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            var list = service.GetStudents();
            foreach (Student student in list)
            {
                Console.WriteLine($"{student.StudentId} {student.Name} {student.Grades}");
            }  
        }
    }
}
