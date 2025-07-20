public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        Span<bool> set1 = stackalloc bool[2001];
        Span<bool> set2 = stackalloc bool[2001];

        foreach(var num in nums1)
            set1[num + 1000] = true;
        foreach(var num in nums2)
            set2[num + 1000] = true;

        var res = new List<IList<int>>(2){
            new List<int>(),
            new List<int>()
        };

        for(int i = 0; i < set1.Length; i++)
        {
            if(set1[i] == set2[i])
                continue;
            
            if(set1[i])
                res[0].Add(i - 1000);
            else if(set2[i])
                res[1].Add(i - 1000);
        }
        return res;
    }
}