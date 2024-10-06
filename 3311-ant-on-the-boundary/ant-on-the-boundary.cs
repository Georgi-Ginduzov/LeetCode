public class Solution {
    public int ReturnToBoundaryCount(int[] nums) {
        int returns = 0;
        int boundary = 0;
        for(int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i-1];
            if(nums[i] == 0)
            {
                returns++;
            }
        }
        return returns;
    }
}