public class Solution {
    public int ArrangeCoins(int n) {
        long low = 0;
        long high = n;
        while(low < high)
        {
            long mid = low + (high-low) / 2;
            if((mid * (mid + 1)) / 2 >= n)
                high = mid;
            else
                low = mid + 1;
        }

        if(high * (high + 1) / 2 <= n)
            return (int)high;
        else
            return (int)(high - 1);
    }
}