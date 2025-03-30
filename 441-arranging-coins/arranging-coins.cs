public class Solution {
    public int ArrangeCoins(int n) {
        long low = 1;
        long high = n;
        while(low <= high)
        {
            long mid = low + (high-low)/2;
            if(mid * (mid + 1) / 2 > n)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        
        return (int)high;
    }
}