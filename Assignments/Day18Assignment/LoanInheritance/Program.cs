namespace LoanInheritance
{

    class Loan
    {
        public string LoanNumber { get; set; }
        public string CustomerName { get; set; }
        public decimal PrincipalAmount { get; set; }
        public int TenureInYears { get; set; }

        public Loan() { }

        public Loan(string id, string name, decimal amount, int years)
        {
            LoanNumber = id;
            CustomerName = name;
            PrincipalAmount = amount;
            TenureInYears = years;
        }

        public double CalculateEMI()
        {
            Console.WriteLine("Loan Class");
            return (double)((PrincipalAmount + PrincipalAmount * 0.10M) / TenureInYears);
        }
    }

    class HomeLoan : Loan
    {
        public HomeLoan(string id, string name, decimal amount, int years) : base(id, name, amount, years)
        {
            LoanNumber = id;
            CustomerName = name;
            PrincipalAmount = amount;
            TenureInYears = years;
        }
        public double CalculateEMI()
        {
            Console.WriteLine("HomeLoan Class");
            return (double)(((PrincipalAmount + PrincipalAmount * 0.09M) / TenureInYears)+PrincipalAmount*0.01M) ;
        }
    }

    class CarLoan : Loan
    {
        public CarLoan(string id, string name, decimal amount, int years) : base(id, name, amount, years)
        {
            LoanNumber = id;
            CustomerName = name;
            PrincipalAmount = amount;
            TenureInYears = years;
        }
        public double CalculateEMI()
        {
            Console.WriteLine("CarLoan Class");
            return (double)((PrincipalAmount + PrincipalAmount * 0.09M + 15000) / TenureInYears);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Loan[] loans = new Loan[]
            {
                new HomeLoan("1001","Aaroh",5000000,5),
                new CarLoan("1002","Mayank",500000,5),
            };

            for (int i = 0; i < loans.Length; i++)
            {
                Console.WriteLine(loans[i].CalculateEMI());
            }
        }
    }
}
