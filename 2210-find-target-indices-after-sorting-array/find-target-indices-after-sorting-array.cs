public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
        Array.Sort(nums);

        int low = 0;
        int high = nums.Length - 1;
        while(low < high)
        {
            int mid = low + (high-low) / 2;
            if(nums[mid] >= target)
                high = mid;
            else
                low = mid+1;
        }

        List<int> res = new List<int>();

        if(nums[high] != target)
            return res;
        
        for(int i = high; i < nums.Length && nums[i] == target; i++)
            res.Add(i);

        return res;
    }
}