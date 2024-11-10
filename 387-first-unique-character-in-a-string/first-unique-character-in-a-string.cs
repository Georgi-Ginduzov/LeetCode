public class Solution {
    public int FirstUniqChar(string s) {
        if(s.Length == 1)
            return 0;
        HashSet<char> repeated = new HashSet<char>();
        for(int i = 0; i < s.Length; i++)
        {
            if(repeated.Contains(s[i]))
                continue;
            int k = i + 1;
            while(k < s.Length && s[k] != s[i])
            {
                k++;
            }
            if(k == s.Length)
                return i;
            repeated.Add(s[i]);
        }
        return -1;
    }
}   