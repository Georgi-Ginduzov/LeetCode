public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var res = new List<int>();
        Array.Sort(nums1);
        Array.Sort(nums2);
        int i = 0;
        foreach(var num in nums1)
        {
            int low = i;
            int high = nums2.Length - 1;
            while(low < high) 
            {
                int mid = low + (high-low)/2;
                if(num <= nums2[mid])
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }

            if(nums2[high] == num && res.Count < nums2.Length && high == low)
            {
                res.Add(nums2[high]);
                i = high+1;
            }
        }
        return res.ToArray();
    }
}