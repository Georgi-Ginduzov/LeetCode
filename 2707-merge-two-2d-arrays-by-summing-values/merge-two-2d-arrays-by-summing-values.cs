public class Solution {
    public int[][] MergeArrays(int[][] nums1, int[][] nums2) {
        SortedDictionary<int, int> merged = new SortedDictionary<int, int>();
        for(int i = 0; i < nums1.Length; i++)
        {
            if(merged.ContainsKey(nums1[i][0]))
                merged[nums1[i][0]] += nums1[i][1];
            else
                merged.Add(nums1[i][0], nums1[i][1]);
        } 
        for(int i = 0; i < nums2.Length; i++)
        {
            if(merged.ContainsKey(nums2[i][0]))
                merged[nums2[i][0]] += nums2[i][1];
            else
                merged.Add(nums2[i][0], nums2[i][1]);
        }
        return merged.Select(kv => new int[] { kv.Key, kv.Value }).ToArray();
    }
}