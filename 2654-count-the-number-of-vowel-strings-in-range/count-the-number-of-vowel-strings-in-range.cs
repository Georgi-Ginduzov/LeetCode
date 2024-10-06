public class Solution {
    public int VowelStrings(string[] words, int left, int right) {
        int vowels = 0;
        for(int i = left; i <= right; i++)
        {
            if(IsVowel(words[i][0]) && IsVowel(words[i][words[i].Length - 1]))
            {
               vowels++;
            }
        }
        return vowels;
    }
    public static bool IsVowel(char x)
    {
        switch(x)
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
}