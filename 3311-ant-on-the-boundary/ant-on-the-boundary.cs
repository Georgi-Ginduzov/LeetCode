public class Solution {
    public int ReturnToBoundaryCount(int[] nums) {
        int returns = 0;
        int boundary = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            boundary += nums[i];
            if(boundary == 0)
            {
                returns++;
            }
        }
        return returns;
    }
}