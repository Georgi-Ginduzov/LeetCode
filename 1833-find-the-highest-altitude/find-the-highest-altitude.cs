public class Solution {
    public int LargestAltitude(int[] gain) {
        var max = 0 > gain[0] ? 0 : gain[0];
        for(int i = 1; i < gain.Length; i++)
        {
            gain[i] = gain[i] + gain[i-1];
            if(gain[i] > max)
                max = gain[i];
        }

        return max;
    }
}