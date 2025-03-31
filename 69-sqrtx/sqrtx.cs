public class Solution {
    public int MySqrt(int x) {
        if(x == 0)
            return 0;
        if(x == 1)
            return 1;
        
        long low = 0;
        long high = x;
        while(low < high)
        {
            long mid = low + (high-low) / 2;

            if(mid * mid >= x)
                high = mid;
            else
                low = mid + 1;
        }

        if(high * high == x)
            return (int)high;
        
        if((high-1)*(high-1) > x)
            return (int)(high - 2);

        return (int)(high-1);
    }
}