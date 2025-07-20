public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        bool[] set = new bool[nums.Length];
        List<int> res = new List<int>(2);
        foreach(var num in nums)
        {
            if(set[num])
                res.Add(num);
            else
                set[num] = true;
        }

        return res.ToArray();
    }
}