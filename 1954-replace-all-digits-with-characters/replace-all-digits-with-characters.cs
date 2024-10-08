public class Solution {
    public string ReplaceDigits(string s) {
        StringBuilder repl = new StringBuilder(s);
        for(int i = 1; i < s.Length; i += 2)
        {
            repl[i] = (char)(s[i-1] + s[i] - 48);
        }
        return repl.ToString();
    }
}