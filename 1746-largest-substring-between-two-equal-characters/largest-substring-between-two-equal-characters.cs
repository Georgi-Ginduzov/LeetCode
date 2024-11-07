public class Solution {
    public int MaxLengthBetweenEqualCharacters(string s) {
        int len =-1;
        for(int i = 0; i < s.Length -1; i++)
        {
            int k = i + 1;
            while(k < s.Length)
            {
                if(s[k] == s[i])
                {
                    len = len > (k-i-1) ? len : (k-i-1);
                }
                k++;
            }
        }
        return len;
    }
}