using LayeredRepo.Model;
using LayeredRepo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredRepo.Services
{
    internal class StudentServices : IStudentServices
    {
        private IStudentRepository _repo { get; set; }
        public StudentServices(IStudentRepository repo)
        {
            _repo = repo;
        }
        public void AddStudent(Student student)
        {
            if (student.Grades > 100 || student.Grades < 0) throw new ArgumentException("Marks should be in range of 0-100");

            _repo.AddStudent(student);
        }

        public IEnumerable<Student> GetStudents()
        {
            var list = _repo.GetStudents();
            if (list == null) throw new ArgumentException("No students exist");
            return list;
        }
    }
}
