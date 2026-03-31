using LayeredRepo.Model;

namespace LayeredRepo.Repositories
{
    internal interface IStudentRepository
    {
        public void AddStudent(Student student);
        public void DeleteStudent(Student student);
        public void UpdateStudent(Student student);
        public IEnumerable<Student> GetStudents();
    }
}
