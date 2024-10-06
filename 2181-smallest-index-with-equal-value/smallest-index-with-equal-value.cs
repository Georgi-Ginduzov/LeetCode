public class Solution {
    public int SmallestEqual(int[] nums) {
        int min = int.MaxValue;
        for(int i = 0; i < nums.Length; i++)
        {
            if(i % 10 == nums[i] && i < min)
            {
                min = i;
                if(min == 0)
                    return min;
            }
        }
        return min == int.MaxValue ? -1 : min;
    }
}