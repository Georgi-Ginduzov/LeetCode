public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> set = new HashSet<int>();
        Array.Sort(nums2);

        foreach(var num in nums1)
        {
            if(set.Contains(num))
                continue;
            
            int low = 0; 
            int high = nums2.Length-1;
            while(low<high)
            {
                int mid = low + (high-low) / 2;
                if(nums2[mid] >= num)
                    high = mid;
                else
                    low = mid + 1;
            }

            if(nums2[high] == num)
                set.Add(num);
        }

        return set.ToArray();
    }
}