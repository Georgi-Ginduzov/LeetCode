public class Solution {
    public bool AreNumbersAscending(string s) {
        int prev = -1;
        for(int i = 0; i < s.Length; i++)
        {
            int k = 0;
            while(i < s.Length && s[i] >= '0' && s[i] <= '9')
            {
                k++;
                i++;
            }
            if(k > 0 && prev >= int.Parse(s.Substring(i-k, k).ToString()))
                return false;
            prev = k > 0 ? int.Parse(s.Substring(i-k, k).ToString()) : prev;
        }
        return true;
    }
}