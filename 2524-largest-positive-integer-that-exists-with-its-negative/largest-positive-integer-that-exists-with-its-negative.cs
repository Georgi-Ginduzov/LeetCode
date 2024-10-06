public class Solution {
    public int FindMaxK(int[] nums) {
        Array.Sort(nums);
        for(int i = 0; i < nums.Length - 1 && nums[i] < 0; i++)
        {       // -7, -1, 1, 6, 7, 10
            for(int j = nums.Length - 1; j > 0 && nums[j] >= -nums[i]; j--)
            {
                if(-nums[i] == nums[j])
                {
                    return nums[j];
                }
            }
        }
        return -1;
    }
}