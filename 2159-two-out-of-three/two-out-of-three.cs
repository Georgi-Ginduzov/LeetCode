public class Solution {
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3) {
        HashSet<int> nums1Set = new HashSet<int>(nums1);
        HashSet<int> nums2Set = new HashSet<int>(nums2);
        HashSet<int> nums3Set = new HashSet<int>(nums3);
        HashSet<int> result = new HashSet<int>();
        foreach(var num in nums1Set)
        {
            if(nums2Set.Contains(num))
            {
                result.Add(num);
                nums2Set.Remove(num);
            }
            if(nums3Set.Contains(num))
            {
                result.Add(num);
                nums3Set.Remove(num);
            }
        }
        foreach(var num in nums2Set)
        {
            if(nums3Set.Contains(num))
            {
                result.Add(num);
                nums3Set.Remove(num);
            }
        }
        return result.ToList();
    }
}