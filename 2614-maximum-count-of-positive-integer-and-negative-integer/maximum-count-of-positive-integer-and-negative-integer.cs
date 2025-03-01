public class Solution {
    public int MaximumCount(int[] nums) {
        int low = 0;
        int high = nums.Length-1;
        int neg = -1;
        while(low <= high)
        {
            int mid = low + (high - low) / 2;
            if(nums[mid] >= 0)
            {
                high = mid - 1;
            }
            else
            {
                neg = mid;
                low = mid + 1;
            }
        }

        low = neg != -1 ? neg : 0;
        high = nums.Length-1;
        int pos = -1;
        while(low <= high)
        {
            int mid = low + (high - low) / 2;
            if(nums[mid] <= 0)
            {
                low = mid + 1;
            }
            else
            {
                pos = mid;
                high = mid - 1;
            }
        }

        if(neg == -1)
        {
            if(pos == -1)
                return 0;
            return nums.Length - pos;
        }
        else if(pos == -1)
        {
            return neg + 1;
        }
        return neg + 1 > nums.Length - pos ? neg + 1 : nums.Length - pos;
    }
}