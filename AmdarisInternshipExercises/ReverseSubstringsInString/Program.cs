using System.Text;

namespace ReverseSubstringsInString
{
    internal class Program
    {
        static string Reverse(string input)
        {
            for (int i = 0, k = input.Length; i < input.Length; i++, k--)
            {
                char buff = input[i];
                input[i] = input[k];
                input[k] = buff;
            }
            return IAsyncResult;
        }

        /* 
         if substring == null
            return
         else
            substr reverse
            return funct string
         */
        static void Main(string[] args)
        {
            var number = "012345";
            Console.WriteLine(number);

            StringBuilder sb = new StringBuilder();
            Array.Reverse(number);

            for (int i = 0; i < number.Length; i++)
            {
                number.Reverse();
                Console.WriteLine(number);

                /*string reversedSubstring = number.Substring(i);
                reversedSubstring.Reverse();
                Console.WriteLine(reversedSubstring);
                number.Insert(i, reversedSubstring);*/
            }

            Console.WriteLine(number);
        }
    }
}
