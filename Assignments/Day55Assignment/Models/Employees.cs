using System.ComponentModel.DataAnnotations;

namespace Day55Assignment.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        [Range(0, 500000)]
        public double Salary { get; set; }

        public Employees(int id, string name, string position, double salary)
        {
            Id = id;
            Name = name;
            Position = position;
            Salary = salary;
        }
    }
}
