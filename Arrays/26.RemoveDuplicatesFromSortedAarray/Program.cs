namespace _26.RemoveDuplicatesFromSortedAarray
{
    internal class Program
    {
        public static int RemoveDuplicates(int[] nums)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>(nums.Length);

            foreach (int n in nums)
            {
                uniqueNumbers.Add(n);
            }

            nums = new int[uniqueNumbers.Count];

            int k = 0;
            foreach (int num in uniqueNumbers)
            {
                nums[k++] = num;
            }

            return uniqueNumbers.Count;
        }

        static void Main(string[] args)
        {
            RemoveDuplicates(new int[] { 1, 1, 2 });
            RemoveDuplicates(new int[] { 1, 1, 2 });

        }
    }
}
