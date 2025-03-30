public class Solution {
    public int MaximumCount(int[] nums) {
        int low = 0; 
        int high = nums.Length - 1;
        while(low <= high)
        {
            int mid = low + (high-low) / 2;
            if(nums[mid] < 0)
                low = mid+1;
            else
                high = mid-1; 
        }
        int neg = high >= 0 ? high + 1 : 0;
        
        high = nums.Length - 1;
        while(low < high)
        {
            int mid = low + (high-low) / 2;
            if(nums[mid] > 0)
                high = mid;
            else
                low = mid + 1;
        }
        int pos = nums[high] > 0 ? nums.Length - high : 0;

        return pos > neg ? pos : neg;
    }
}