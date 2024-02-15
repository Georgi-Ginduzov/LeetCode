namespace ContainsDublicate
{
    internal class Program
    {
        static bool ContainsDublicate(int[] nums)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>(nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                if (uniqueNumbers.Add(nums[i]))
                {

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
