namespace EmployeeCompensation
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public decimal BasicSalary { get; set; }
        public int ExperienceInYears { get; set; }

        public Employee(int id, string name, decimal salary, int years)
        {
            EmployeeID = id;
            EmployeeName = name;
            BasicSalary = salary;
            ExperienceInYears = years;
        }
        public decimal CalculateAnnualSalary()
        {
            return BasicSalary * 12;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"{EmployeeID} {EmployeeName} {BasicSalary} {ExperienceInYears} {CalculateAnnualSalary()}");
        }
    }

    class PermenantEmployee : Employee
    {
        public PermenantEmployee(int id, string name, decimal salary, int years) : base(id, name, salary, years)
        {
        }
        public new decimal CalculateAnnualSalary()
        {
            decimal LoyaltyBonus = 0;
            if (ExperienceInYears >= 5) LoyaltyBonus = 50000;
            return ((BasicSalary * 0.2M) + (BasicSalary * 0.1M) + BasicSalary) * 12 + LoyaltyBonus;
        }
    }

    class ContractEmployee : Employee
    {
        public int ContractDurationInMonths { get; set; }
        public ContractEmployee(int id, string name, decimal salary, int years, int duration) : base(id, name, salary, years)
        {
            ContractDurationInMonths = duration;
        }
        

        public new decimal CalculateAnnualSalary()
        {
            decimal CompletionBonus = 0;
            if (ContractDurationInMonths >= 12) CompletionBonus = 50000;
            return (BasicSalary * 12) + CompletionBonus;
        }

    }

    class InternEmployee : Employee
    {
        public InternEmployee(int id, string name, decimal salary, int years) : base(id, name, salary, years) {}

        public new decimal CalculateAnnualSalary()
        {
            return BasicSalary * 12;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1001,"Aaroh",30000,3);
            PermenantEmployee emp2 = new PermenantEmployee(1002, "Mayank", 30000, 3);
            InternEmployee emp3 = new InternEmployee(1003, "Teesra", 30000, 3);
            ContractEmployee emp4 = new ContractEmployee(1004, "Chautha", 30000, 3, 24);

            Console.WriteLine(emp1.CalculateAnnualSalary());
            Console.WriteLine(emp2.CalculateAnnualSalary());
            Console.WriteLine(emp3.CalculateAnnualSalary());
            Console.WriteLine(emp4.CalculateAnnualSalary());
        }
    }
}
