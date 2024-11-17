public class Solution {
    public int CountPrefixSuffixPairs(string[] words) {
        int pairs = 0;
        for(int i = 0; i < words.Length - 1; i++)
        {
            for(int j = i + 1; j < words.Length; j++)
            {
                if(isPrefixAndSuffix(words[i], words[j]))
                    pairs++;
            }
        }
        return pairs;
    }

    public static bool isPrefixAndSuffix(string str1, string str2)
    {
        if(str1.Length > str2.Length)
            return false;
        int i = 0;
        while(i < str1.Length && str1[i] == str2[i] && str1[i] == str2[str2.Length - str1.Length + i]) 
        {
            i++;
        }
        if(i == str1.Length)
            return true;
        return false;
    }
}