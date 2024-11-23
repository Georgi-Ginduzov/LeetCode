public class Solution {
    public string LongestNiceSubstring(string s) {
        if(s.Length < 2)
            return "";
        HashSet<char> set = new HashSet<char>(s);
        for(int i = 0; i < s.Length; i++)
        {
            if(set.Contains(char.ToUpper(s[i])) && set.Contains(char.ToLower(s[i])))
            {
                continue;
            }

            string substr = LongestNiceSubstring(s.Substring(0, i));
            string substr2 = LongestNiceSubstring(s.Substring(i+1));

            return substr.Length >= substr2.Length ? substr : substr2;
        }
        return s;
    }
}