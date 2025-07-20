public class Solution {
    public int MaximumNumberOfStringPairs(string[] words) {
        int pairs = 0;

        for(int i = 0; i < words.Length - 1; i++)
        {
            int j = i + 1;
            while(j < words.Length)
            {
                if(IsPair(words[i], words[j]))
                {
                    pairs++;
                    break;
                }
                j++;
            }
        }

        return pairs;
    }

    public bool IsPair(string word, string other)
        => word[0] == other[1] && word[1] == other[0];
}