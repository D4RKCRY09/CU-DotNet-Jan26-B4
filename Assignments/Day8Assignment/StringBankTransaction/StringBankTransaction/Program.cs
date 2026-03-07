namespace StringBankTransaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.ToLower();
            string[] inputArr = input.Split('#', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            string transID = inputArr[0];
            string accName = inputArr[1];
            string transNarr = inputArr[2];

            string[] validTrans = { "deposit", "withdrawl", "transfer" };

            string category = "";
            if (string.IsNullOrEmpty(transNarr)) category = "NON-FINANCIAL TRANSACTION";
            else
            {
                for (int i = 0; i < validTrans.Length; i++)
                {
                    if (transNarr.IndexOf(validTrans[i]) != -1)
                    {
                        category = "STANDARD TRANSACTION";
                        break;
                    }
                    else category = "CUSTOM TRANSCATION";
                }
            }

            Console.WriteLine($"Transaction ID {":",1} {transID.ToUpper()}");
            Console.WriteLine($"Account Holder {":",1} {accName}");
            Console.WriteLine($"Narration {":",6} {transNarr}");
            Console.WriteLine($"Category {":",7} {category}");
        }
    }
}
