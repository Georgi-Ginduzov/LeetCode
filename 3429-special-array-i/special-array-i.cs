public class Solution {
    public bool IsArraySpecial(int[] nums) {
        switch(nums.Length)
        {
            case 1:
                return true;
            case 2: 
                return nums[0] % 2 != nums[1] % 2;
            default:
                for(int i = 1; i < nums.Length - 1; i++)
                {
                    if(nums[i-1] % 2 != nums[i+1] % 2 || nums[i] % 2 == nums[i+1] % 2)
                    {
                        return false;
                    }
                }
                return true;
        }
    }
}