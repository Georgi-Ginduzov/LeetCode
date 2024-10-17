public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder merged = new StringBuilder();
        if(word1.Length <= word2.Length)
        {
            for(int i = 0; i < word1.Length; i++)
            {
                merged.Append(word1[i]);
                merged.Append(word2[i]);
            }
            for(int i = word1.Length; i < word2.Length; i++)
            {
                merged.Append(word2[i]);
            }
        }
        else
        {
            for(int i = 0; i < word2.Length; i++)
            {
                merged.Append(word1[i]);
                merged.Append(word2[i]);
            }
            for(int i = word2.Length; i < word1.Length; i++)
            {
                merged.Append(word1[i]);
            }
        }
        return merged.ToString();
    }
}