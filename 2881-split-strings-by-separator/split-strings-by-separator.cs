public class Solution {
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator) {
        List<string> wordsList = new List<string>();
        for(int i = 0; i < words.Count; i++)
        {
            int start = 0;
            for(int j = 0; j < words[i].Length; j++)
            {
                if(words[i][j] == separator)
                {
                    if(j - start >= 1)
                        wordsList.Add(words[i].Substring(start, j - start));
                    start = j + 1;
                }
            }
            if(start < words[i].Length)
            {
                wordsList.Add(words[i].Substring(start, words[i].Length - start));
            }
        }
        return wordsList;
    }
}