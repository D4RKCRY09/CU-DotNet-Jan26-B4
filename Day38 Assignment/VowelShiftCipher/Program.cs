namespace VowelShiftCipher
{
    internal class Program
    {

        static string VoweShiftCippher(string s)
        {
            s = s.Trim().ToLower();
            string ans = "";
            List<char> vowels = new List<char>() {'a','e','i','o','u'};
            foreach(var c in s)
            {
                int num = vowels.IndexOf(c);
                if (num != -1)
                {
                    ans += (num != 4) ? vowels[num + 1]: vowels[0];
                }
                else
                { 
                    if(c=='z')
                    {
                        ans += 'b';
                        continue;
                    }
                    int temp = (int)c + 1;
                    if (vowels.Contains((char)temp)) temp++;

                    ans += (char)temp;
                }
            }
            return ans;
        }
        static void Main(string[] args)
        {
            string input = "dfhj fgjk hello jimmu aeiou eioua apple eqqmi crypt dszqv";
            string[] arr = input.Split(' ');
            foreach(var s in arr)
            {
                Console.WriteLine(VoweShiftCippher(s));
            }
        }
    }
}
