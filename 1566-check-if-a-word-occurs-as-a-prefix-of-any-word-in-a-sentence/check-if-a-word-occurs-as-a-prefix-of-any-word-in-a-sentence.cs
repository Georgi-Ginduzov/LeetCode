public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        int words = 1;
        for (int i = 0; i < sentence.Length; i++)
        {
            if(i == 0 || sentence[i-1] == ' ')
            {
                int j = 0;
                while(i < sentence.Length && j < searchWord.Length && sentence[i] == searchWord[j])
                {
                    i++;
                    j++;
                }
                if(j == searchWord.Length)
                    return words;
                words++;                
            }
        }
        return -1;
    }
}