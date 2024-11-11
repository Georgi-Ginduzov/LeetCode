public class Solution {
    public int CountVowelSubstrings(string word) {
        int substrings = 0;
        for(int i = 0; i < word.Length - 1; i++)
        {
            if(IsVowel(word[i]))
            {
                int j = i + 1;
                while(j < word.Length && IsVowel(word[j]))
                {
                    if(IsValid(word.Substring(i, j-i+1)))
                        substrings++;
                    j++;
                }
            }
        }
        return substrings;
    }
    public static bool IsVowel(char letter)
    {
        switch(letter)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                return true;
            default:
                return false;
        }
    }
    public static bool IsValid(string word)
    {
        return word.Contains('a') && word.Contains('e') && word.Contains('i') && word.Contains('o') && word.Contains('u');
    }
}