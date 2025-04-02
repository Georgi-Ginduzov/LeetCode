public class Solution {
    public bool IsPerfectSquare(int num) {
        long low = 0;
        long high = num;

        while(low < high)
        {
            long mid = low + (high-low) / 2;
            if(mid * mid >= num)
                high = mid;
            else
                low = mid + 1;
        }
        
        if(high*high == num)
            return true;
        else
            return false;
    }
}