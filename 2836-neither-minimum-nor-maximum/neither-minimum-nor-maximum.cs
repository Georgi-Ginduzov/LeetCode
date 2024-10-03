public class Solution {
    public int FindNonMinOrMax(int[] nums) {
        if(nums.Length < 3)
        {
            return -1;
        }
        Array.Sort(nums);
        if(nums[nums.Length- 2] > nums[0] && nums[nums.Length - 2] < nums[nums.Length - 1])
        {
            return nums[nums.Length - 2];
        }
        return -1;
    }
}