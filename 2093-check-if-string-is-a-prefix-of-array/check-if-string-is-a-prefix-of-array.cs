public class Solution {
    public bool IsPrefixString(string s, string[] words) {
        StringBuilder prefix = new StringBuilder();
        for(int i = 0; i < words.Length; i++)
        {
            if(prefix.Length < s.Length)
                prefix.Append(words[i]);
            else if(prefix.Length == s.Length)
                break;
        }
        return prefix.ToString() == s;
    }
}