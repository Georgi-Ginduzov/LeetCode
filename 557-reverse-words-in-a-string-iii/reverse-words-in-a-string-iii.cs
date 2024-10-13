public class Solution {
    public string ReverseWords(string s) {
        char[] res = new char[s.Length];
        int from = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == ' ')
            {
                Array.Reverse(res, from, i - from);
                res[i] = ' ';
                from = i + 1;
            }
            else
            {
                res[i] = s[i];
            }
        }
        Array.Reverse(res, from, s.Length - from);
        return new string(res);
    }
}