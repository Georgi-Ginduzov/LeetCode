namespace ValidAnagram
{
    internal class Program
    {
        static bool IsAnagram(string s, string t)
        {
            if (s.Length == t.Length)
            {
                Dictionary<char, int> sLetters = new Dictionary<char, int>(s.Length);
                Dictionary<char, int> tLetters = new Dictionary<char, int>(s.Length);
                for (int i = 0; i < s.Length; i++)
                {
                    sLetters[s[i]] = sLetters[s[i]] + 1;
                    sLetters[t[i]] = sLetters[t[i]] + 1;
                }

                foreach (var letter in sLetters.Keys)
                {
                    if (tLetters[letter] != sLetters[letter])
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

            return true;
        }
        static bool IsAnagramm(string s, string t)
        {
            char[] sArray = s.ToCharArray();
            char[] tArray = t.ToCharArray();

            Array.Sort(sArray);
            Array.Sort(tArray);

            s = new string(sArray);
            t = new string(tArray);

            Console.WriteLine(s);
            Console.WriteLine(t);
            if (s == t)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            
            s.OrderBy(x => x.ToString());

            Console.WriteLine(IsAnagramm(s, t));
        }
    }
}
