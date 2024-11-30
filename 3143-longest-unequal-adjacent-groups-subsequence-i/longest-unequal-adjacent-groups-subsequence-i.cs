public class Solution {
    public IList<string> GetLongestSubsequence(string[] words, int[] groups) {
        IList<string> data = new List<string>();
        for(int i = 0; i < groups.Length - 1; i++)
        {
            if(groups[i] == groups[i+1])
            {
                words[i] = string.Empty;
            }
            else
            {
                data.Add(words[i]);
            }
        }
        data.Add(words[words.Length-1]);
        return data;
    }
}