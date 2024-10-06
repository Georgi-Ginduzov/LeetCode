public class Solution {
    public int SingleNumber(int[] nums) {
        for(int i = 1; i < nums.Length; i++)
        {
            nums[i] ^= nums[i-1];
        }
        return nums[nums.Length - 1];
    }
}