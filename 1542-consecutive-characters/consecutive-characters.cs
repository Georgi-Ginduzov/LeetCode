public class Solution {
    public int MaxPower(string s) {
        int max = 0;
        for(int i = 0; i < s.Length; i++)
        {
            int k = i+1;
            while(k < s.Length && s[k] == s[i])
            {
                k++;
            }
            max = max > (k - i) ? max : (k - i);
        }
        return max;
    }
}