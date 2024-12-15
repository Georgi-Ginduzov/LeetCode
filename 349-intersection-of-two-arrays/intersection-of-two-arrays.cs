public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> set2 = new HashSet<int>(nums2);
        HashSet<int> intersections = new HashSet<int>();
        foreach(var num in set1)
        {
            if(set2.Contains(num))
                intersections.Add(num);
        }
        return intersections.ToArray();
    }
}