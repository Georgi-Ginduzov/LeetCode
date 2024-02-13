namespace ContainsDublicate
{
    internal class Program
    {
        static bool ContainsDublicate(int[] nums)
        {
            Dictionary<int, int> uniqueNumbers = new Dictionary<int, int>();
            int i = 0;
            
            foreach (int num in nums)
            {
                if (!uniqueNumbers.ContainsValue(num))
                {
                    uniqueNumbers.Add(i, num);
                    i++;
                }
                else
                {
                    return true;
                }
            }

             return false;
           
        }
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(ContainsDublicate(inputArray));
        }
    }
}
