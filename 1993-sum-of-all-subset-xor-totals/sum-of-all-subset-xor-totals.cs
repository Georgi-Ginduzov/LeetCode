public class Solution {
    public int SubsetXORSum(int[] nums) {
        return Subset(nums, 0, 0);
    }

    public int Subset(int[] nums, int i,int current)
    {
        if(i >= nums.Length)
            return current;
        else
            return Subset(nums, i + 1, nums[i] ^ current) + Subset(nums, i + 1, current);
    }
}