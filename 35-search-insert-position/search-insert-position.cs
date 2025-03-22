public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if(nums[0] >= target)
            return 0;
        else if(nums[nums.Length - 1] < target)
            return nums.Length;
        
        int low = 0;
        int high = nums.Length;
        while(low < high)
        {
            int mid = low + (high - low) / 2;
            if(nums[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }
        return high;
    }
}