public class Solution {
    public bool IsPerfectSquare(int num) {
        if(num == 1)
            return true;
        long low = 0;
        long high = num / 2;
        while(low < high)
        {
            long mid = low + (high-low) / 2;
            if(mid*mid >= num)
                high = mid;
            else
                low = mid + 1;
        }

        if(low*low == num)
            return true;
        return false;
    }
}