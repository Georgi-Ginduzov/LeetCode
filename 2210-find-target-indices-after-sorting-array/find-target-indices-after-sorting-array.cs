public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
        Array.Sort(nums);
        List<int> indices = new List<int>();
        for(int i = 0; i < nums.Length && nums[i] <= target; i++)
        {
            if(nums[i] == target)
            {
                indices.Add(i);
            }
        }
        return indices;
    }
}