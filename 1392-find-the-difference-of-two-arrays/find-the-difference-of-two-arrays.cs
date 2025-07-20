public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        var res = new List<List<int>>(2){
            new List<int>(),
            new List<int>()
        };

        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);
        foreach(var num in set2)
            if(!set1.Contains(num))
                res[1].Add(num);
        foreach(var num in set1)
            if(!set2.Contains(num))
                res[0].Add(num);
        
        return res.Cast<IList<int>>().ToList();
    }
}