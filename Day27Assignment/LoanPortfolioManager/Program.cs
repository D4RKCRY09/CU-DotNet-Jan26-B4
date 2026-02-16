using System.ComponentModel.Design;

namespace LoanPortfolioManager
{
    class Loan
    {
        public string ClientName { get; set; }
        public double Principal { get; set; }
        public double InterestRate { get; set; }

    }

    internal class Program
    {
        static List<Loan> loanlist = new List<Loan>();

        public static void AddToList(string s)
        {
            try
            {
                string[] arr = s.Split(',');

                Loan tempLoan = new Loan()
                {
                    ClientName = arr[0],
                    Principal = double.Parse(arr[1]),
                    InterestRate = double.Parse(arr[2])
                };

                loanlist.Add(tempLoan);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Error");
            }
        }

        static void AddToCSV(string filepath)
        {
            using StreamWriter writer = new StreamWriter(filepath, true);

            string[] riskLevel = { "LOW", "MEDIUM", "HIGH" };
            foreach (var thisloan in loanlist)
            {
                double interestRate = thisloan.InterestRate;
                string currentRisk;
                if (interestRate > 10) currentRisk = riskLevel[2];
                else if (interestRate >= 5 && interestRate <= 10) currentRisk = riskLevel[1];
                else currentRisk = riskLevel[0];

                writer.WriteLine($"{thisloan.ClientName},{thisloan.Principal},{interestRate},{currentRisk}");
            }
        }

        static void ReadCSV(string filepath)
        {
            Console.WriteLine($"{"Client",-10}| {"Principal",-10} | {"Interest",-10} | {"Risk Level",-10}");
            Console.WriteLine();
            StreamReader reader = new StreamReader(filepath);
            string? line = reader.ReadLine();
            while (line!=null)
            {
                string[] arr = line.Split(',');
                //Console.WriteLine(line);
                //Console.WriteLine(string.Join(" | ", arr));

                foreach(string str in arr)
                {
                    Console.Write($"{str,-10} |");
                }
                Console.WriteLine();
                line = reader.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            string filepath = @"../../../loandetails.csv";

            string check = string.Empty;

            Console.WriteLine("Enter your details (Enter STOP to stop entering)");

            while (true)
            {
                check = Console.ReadLine();
                if (check.ToLower() == "stop") break;
                else
                {
                    AddToList(check);
                }
            }

            AddToCSV(filepath);

            ReadCSV(filepath);       
        }
    }
}
