public class Solution {
    public void ReverseString(char[] s) {
        for(int i = 0; i < s.Length / 2; i++)
        {
            char buff = s[i];
            s[i] = s[s.Length - 1 - i];
            s[s.Length - 1 - i] = buff;
        }
    }
}