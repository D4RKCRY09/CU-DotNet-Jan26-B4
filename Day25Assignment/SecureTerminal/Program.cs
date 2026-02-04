namespace SecureTerminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actual_pin = "1234";
            int i = 4;
            string pin = string.Empty;
            string e = string.Empty;
            while (i > 0)
            {
                ConsoleKeyInfo con = Console.ReadKey(true);

                if (con.Key != ConsoleKey.Backspace)
                {
                    if (char.IsDigit(con.KeyChar))
                    {
                        e += '*';
                        pin += con.KeyChar;

                    }
                    else i++;
                }
                else
                {
                    pin = pin.Remove(pin.Length - 1);
                    e = e.Remove(e.Length - 1);
                    i = i + 2;
                }
                Console.Clear();
                Console.Write(e);
                i--;
            }
            Console.WriteLine();
            if (pin == actual_pin) Console.WriteLine("Pin is Correct");
            else Console.WriteLine("Pin is Wrong");

        }
    }
}
