public class Solution {
    public int[] RunningSum(int[] nums) {
        return Sum(nums).ToArray();
    }
    public static IEnumerable<int> Sum(int[] nums)
    {
        int sum = 0;
        foreach (int i in nums)
        {
            sum += i;
            yield return sum;
        }
    }
}