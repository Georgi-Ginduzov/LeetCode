public class Solution {
    public int BalancedStringSplit(string s) {
        int substrings = 0;
        for(int i = 0; i < s.Length; i++)
        { 
            int balance = s[i] == 'L' ? -1 : 1;
            while(i < s.Length - 1 && balance != 0)
            {
                balance += s[++i] == 'L' ? -1 : 1;
            }
            if(balance == 0)
            {
                substrings++;
            }
        }
        return substrings;
    }
}