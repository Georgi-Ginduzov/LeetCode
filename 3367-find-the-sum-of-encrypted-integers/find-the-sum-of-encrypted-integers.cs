public class Solution {
    public int SumOfEncryptedInt(int[] nums) {
        int sum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            sum += Encrypt(nums[i]);
        }
        return sum;
    }
    public static int Encrypt(int n)
    {
        if(n < 10)
        {
            return n;
        }
        string copy = n.ToString();
        int max = 0;
        foreach(var digit in copy)
        {
            if((digit - 48) > max)
            {
                max = digit - 48;
            }
        }
        n = 0;
        for(int i = 0; i < copy.Length; i++)
        {
            n += (max * IntPow(10, i));
        }
        return n;
    }
    public static int IntPow(int x, int pow)
    {
        int ret = 1;
        while ( pow != 0 )
        {
            if ( (pow & 1) == 1 )
                ret *= x;
            x *= x;
            pow >>= 1;
        }
        return ret;
    }
}