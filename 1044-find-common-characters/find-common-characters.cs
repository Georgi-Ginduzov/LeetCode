public class Solution {
    public IList<string> CommonChars(string[] words) {
        int[] commonCount = new int[26];
        for(int i = 0; i < words[0].Length; i++)
        {
            commonCount[words[0][i] - 'a']++;
        }
        for(int i = 1; i < words.Length; i++)
        {
            int[] wordCount = new int[26];
            for(int j = 0; j < words[i].Length; j++)
            {
                wordCount[words[i][j] - 'a']++;
            }

            for(int j = 0; j < wordCount.Length; j++)
            {
                commonCount[j] = commonCount[j] < wordCount[j] ? commonCount[j] : wordCount[j];
            }
        }
        List<string> commonChars = new List<string>();
        for(int i = 0; i < commonCount.Length; i++)
        {
            for(int j = 0; j < commonCount[i]; j++)
            {
                commonChars.Add(((char)('a' + i)).ToString());
            }
        }
        return commonChars;
    }
}