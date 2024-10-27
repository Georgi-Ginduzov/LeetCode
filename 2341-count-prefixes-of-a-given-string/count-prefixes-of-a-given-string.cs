public class Solution {
    public int CountPrefixes(string[] words, string s) {
        int prefixes = 0;
        foreach(var word in words)
        {
            int k = 0; 
            while(k < s.Length && k < word.Length && word[k] == s[k])
            {
                k++;
            }
            if(k == word.Length)
                prefixes++;
        }
        return prefixes;
    }
}