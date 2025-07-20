public class Solution {
    public int[] RunningSum(int[] nums) {
        int[] sum = new int[nums.Length];
        sum[0] = nums[0];
        for(int i = 1; i < nums.Length; i++)
            sum[i] = nums[i] + sum[i-1];
        
        return sum;
    }
}