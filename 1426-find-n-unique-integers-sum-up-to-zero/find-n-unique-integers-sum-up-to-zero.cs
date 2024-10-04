public class Solution {
    public int[] SumZero(int n) {
        int[] nums = new int[n];
        if(n % 2 == 0)
        {
            for(int i = 1; i <= n / 2; i++)
            {
                nums[i-1] = i;
                nums[n - i] = -i;
            }
        }
        else{
            for(int i = 1; i <= (n / 2); i++)
            {
                nums[i] = i;
                nums[n - i] = -i;
            } 
            nums[0] = 0;
        }
        return nums;
    }
}