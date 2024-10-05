public class Solution {
    public int MaximumStrongPairXor(int[] nums) {
        int max = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i; j < nums.Length; j++)
            {
                if(Math.Abs(nums[i] - nums[j]) <= (nums[i] < nums[j] ? nums[i] : nums[j]))
                {
                    if((nums[i] ^ nums[j]) > max)
                    {
                        max = nums[i] ^ nums[j];
                    }
                }
            }
        }
        return max;
    }
}