public class Solution {
    public int CountWords(string[] words1, string[] words2) {
        Dictionary<string, int> word1 = new Dictionary<string, int>();
        foreach(var word in words1)
        {
            if(word1.ContainsKey(word) == false)
                word1.Add(word, 1);
            else
                word1[word]++;
        }
        Dictionary<string, int> word2 = new Dictionary<string, int>();
        foreach(var word in words2)
        {
            if(word2.ContainsKey(word) == false)
                word2.Add(word, 1);
            else
                word2[word]++;
        }
        int uniqueCommon = 0;
        foreach(var pair in word1)
        {
            if(pair.Value == 1 && word2.ContainsKey(pair.Key) && word2[pair.Key] == 1)
                uniqueCommon++;
        }
        return uniqueCommon;
    }
}