public class Solution {
    public bool CheckString(string s) {
        int i = 0; 
        while(i < s.Length && s[i] != 'b')
        {
            i++;
        }
        while(i < s.Length && s[i] == 'b')
        {
            i++;
        }
        return i == s.Length;
    }
}