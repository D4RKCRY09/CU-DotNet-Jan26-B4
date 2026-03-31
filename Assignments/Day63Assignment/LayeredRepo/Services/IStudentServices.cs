using LayeredRepo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredRepo.Services
{
    internal interface IStudentServices
    {
        public void AddStudent(Student student);

        public void RemoveStudent(Student student);
        public IEnumerable<Student> GetStudents();
    }
}
