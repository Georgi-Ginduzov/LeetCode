public class Solution {
    public int SubsetXORSum(int[] nums) => Subsets(nums, 0, 0);

    public int Subsets(int[] nums, int i, int curr)
        => i >= nums.Length ? curr : Subsets(nums, i + 1, nums[i] ^ curr) + Subsets(nums, i + 1, curr);
}