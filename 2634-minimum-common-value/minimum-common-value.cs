public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        for(int i = 0; i < nums1.Length; i++)
        {
            int low = 0;
            int high = nums2.Length-1;
            while(low <= high)
            {
                int mid = low + (high-low)/2;
                if(nums2[mid] == nums1[i])
                    return nums1[i];
                if(nums2[mid] > nums1[i])
                {
                    high = mid-1;
                }
                else
                {
                    low = mid + 1;
                }
            }
        }
        return -1;
    }
}