public class Solution {
    public int[] FindIntersectionValues(int[] nums1, int[] nums2) {
        int[] res = new int[2];
        
        var set = new HashSet<int>(nums2);
        res[0] = nums1.Count(n => set.Contains(n));
        
        set = new HashSet<int>(nums1);
        res[1] = nums2.Count(n => set.Contains(n));

        return res;
    }
}