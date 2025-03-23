/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int low = 0;
        while(low < n)
        {
            int mid = low + (n-low) / 2;
            if(IsBadVersion(mid))
                n = mid;
            else
                low = mid + 1;
        }
        return n;
    }
}