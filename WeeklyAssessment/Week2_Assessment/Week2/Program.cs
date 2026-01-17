namespace Week2
{
    internal class Program
    {
        static bool Validate(string s)
        {
            return !(string.IsNullOrEmpty(s));
        }
        static bool Validate(decimal s)
        {
            return (s > 0);
        }
        static void EnterName(string[] policyHolderNames, int i)
        {
            if (i >= policyHolderNames.Length) return;
            Console.WriteLine();
            Console.Write($"Enter policy holder number {i + 1} name: ");
            string name = Console.ReadLine();
            if (Validate(name)) policyHolderNames[i] = name;
            else
            {
                Console.WriteLine("Invalid Name. Renter");
                i--;
            }
            EnterName(policyHolderNames, i + 1);
        }
        static void EnterValues(decimal[] annualPremiums, int i)
        {
            if (i >= annualPremiums.Length) return;
            Console.WriteLine();
            Console.Write($"Enter policy holder number {i + 1} annual premium amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            if (Validate(amount)) annualPremiums[i] = amount;
            else
            {
                Console.WriteLine("Invalid Amount. Renter");
                i--;
            }
            EnterValues(annualPremiums, i + 1);
        }
        static decimal CalculateTotal(decimal[] annualPremiums, int i)
        {
            if (i >= annualPremiums.Length) return 0;
            return annualPremiums[i] + CalculateTotal(annualPremiums, i + 1);
        }

        static string Categorize(decimal annualPremium)
        {
            string[] options = { "Low", "Medium", "High" };

            string category = "";
            if (annualPremium < 10000) category = options[0];
            else if (annualPremium >= 10000 && annualPremium <= 25000) category = options[1];
            else if (annualPremium > 25000) category = options[2];

            return category;
        }
        static void Main(string[] args)
        {
            string[] policyHolderNames = new string[5];
            decimal[] annualPremiums = new decimal[5];

            EnterName(policyHolderNames, 0);
            Console.WriteLine();
            EnterValues(annualPremiums, 0);

            decimal total = CalculateTotal(annualPremiums, 0);
            decimal average = total / annualPremiums.Length;

            decimal highest = annualPremiums.Max();
            decimal lowest = annualPremiums.Min();

            Console.WriteLine();
            Console.WriteLine("Insurance Premium Summary");
            Console.WriteLine($"{"Name",-20} {"Premium",-20:F2} {"Category"} ");
            Console.WriteLine("----------------------------------------------------");

            for (int i = 0; i < policyHolderNames.Length; i++)
            {
                Console.WriteLine($"{policyHolderNames[i].ToUpper(),-20} {annualPremiums[i],-20} {Categorize(annualPremiums[i]).ToUpper()} ");
            }

            Console.WriteLine();
            Console.WriteLine($"Total Premium {":",3} {total:F2}");
            Console.WriteLine($"Average Premium {":",1} {average:F2}");
            Console.WriteLine($"Highest Premium {":",1} {highest:F2}");
            Console.WriteLine($"Lowest Premium {":",2} {lowest:F2}");

        }
    }
}
