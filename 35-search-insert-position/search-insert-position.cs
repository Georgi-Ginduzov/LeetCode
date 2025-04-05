public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if(nums[nums.Length-1] < target)
            return nums.Length;
        
        int low = 0; 
        int high = nums.Length - 1;
        while(low < high)
        {
            int mid = low + (high-low) / 2;
            if(nums[mid] >= target)
                high = mid;
            else
                low = mid + 1;
        }

        return high;
    }
}