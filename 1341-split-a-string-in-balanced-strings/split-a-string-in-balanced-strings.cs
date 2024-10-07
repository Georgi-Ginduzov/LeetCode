public class Solution {
    public int BalancedStringSplit(string s) {
        int substrings = 0;
        int balance = s[0] == 'L' ? -1 : 1;
        for(int i = 1; i < s.Length; i++)
        { 
            balance += s[i] == 'L' ? -1 : 1;
            if(balance == 0)
            {
                substrings++;
            }
        }
        return substrings;
    }
}