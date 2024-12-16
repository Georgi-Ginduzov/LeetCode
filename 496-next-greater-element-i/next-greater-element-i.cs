public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] result = new int[nums1.Length];
        for(int i = 0; i < nums1.Length; i++)
        {
            result[i] = -1;
            for(int j = Array.IndexOf(nums2, nums1[i]) + 1; j < nums2.Length; j++)
            {
                if(nums2[j] > nums1[i])
                {
                    result[i] = nums2[j];
                    break;
                }
            }
        }
        return result;
    }
}
