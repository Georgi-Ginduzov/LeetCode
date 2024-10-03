public class Solution {
    public int RepeatedNTimes(int[] nums) {
        HashSet<int> unique = new HashSet<int>(nums.Length / 2 + 1);
        for(int i = 0; i < nums.Length; i++)
        {
            if(unique.Add(nums[i]) == false){
                return nums[i];
            }
        }
        return nums[0];
    }
}