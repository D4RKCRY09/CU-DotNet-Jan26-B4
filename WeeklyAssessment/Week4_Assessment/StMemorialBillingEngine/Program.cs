

using System.Text;

namespace StMemorialBillingEngine
{

    class Patient
    {
        
        public string? Name { get; set; }
        public decimal BaseFee { get; set; }

        public virtual decimal CalculateFinallBill()
        {
            return BaseFee;
        }
        public override string ToString()
        {
            return $"Name = {Name}, Total Bill = {CalculateFinallBill():C}";
        }
    }

    class Inpatient : Patient
    {
        public int DaysStayed { get; set; }
        public decimal DailyRate { get; set; }

        public override decimal CalculateFinallBill()
        {
            return base.CalculateFinallBill() + (DaysStayed * DailyRate);
        }
    }
    class Outpatient : Patient
    {
        public decimal ProcedureFee { get; set; }

        public override decimal CalculateFinallBill()
        {
            return base.CalculateFinallBill() + ProcedureFee;
        }
    }
    class Emergencypatient : Patient
    {
        private int severity;

        public int SeverityLevel
        {
            get { return severity; }
            set { if (value >= 1 && value <= 5) severity = value; }
        }


        public override decimal CalculateFinallBill()
        {
            return base.CalculateFinallBill() * SeverityLevel;
        }
    }

    class HospitalBilling
    {
        public List<Patient> patients = new List<Patient>();

        public void AddPatient(Patient p)
        {
            patients.Add(p);
        }

        public string GenerateDailyReport()
        {
            string report = string.Empty;
            foreach (Patient p in patients)
            {
                report += p;
                report += "\n";
            }
            return report;
        }

        public decimal CalculateTotalRevenue()
        {
            decimal totalRevenue = 0;
            foreach (Patient p in patients)
            {
                totalRevenue += p.CalculateFinallBill();
            }
            return totalRevenue;
        }

        public int GetInpatientCount()
        {
            int count = 0;
            foreach (Patient p in patients)
            {
                if (p is Inpatient) count++;
            }
            return count;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            HospitalBilling h1 = new HospitalBilling();

            h1.AddPatient(new Patient()
            {
                Name = "First",
                BaseFee = 1000
            });
            h1.AddPatient(new Inpatient()
            {
                Name = "Second",
                BaseFee = 1000,
                DaysStayed = 1,
                DailyRate = 500
            });
            h1.AddPatient(new Outpatient()
            {
                Name = "Third",
                BaseFee = 1000,
                ProcedureFee = 10000
            });
            h1.AddPatient(new Emergencypatient()
            {
                Name = "Fourth",
                BaseFee = 1000,
                SeverityLevel = 4,
            });

            Console.WriteLine(h1.GenerateDailyReport());
            Console.WriteLine($"Total Revenue Generated = {h1.CalculateTotalRevenue():C}");
            Console.WriteLine($"Number of Inpatients = {h1.GetInpatientCount()}");

        }

    }
}
