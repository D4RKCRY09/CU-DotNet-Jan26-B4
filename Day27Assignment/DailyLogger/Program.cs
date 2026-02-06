namespace DailyLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your daily reflection");

            string filepath = @"../../../journal.txt";

            if(!Path.Exists(filepath))
            {
                File.Create(filepath);
            }

            using StreamWriter writer = new StreamWriter(filepath,true);

            string? input = Console.ReadLine();

            writer.WriteLine(input);
        }
    }
}
