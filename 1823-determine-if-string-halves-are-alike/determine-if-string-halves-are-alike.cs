public class Solution {
    public bool HalvesAreAlike(string s) {
        int balance = 0;
        for(int i = 0; i < s.Length / 2; i++)
        {
            balance += (IsVowel(s[i]) - IsVowel(s[s.Length - 1 - i]));
        }
        return balance == 0;
    }
    public static int IsVowel(char v)
    {
        switch(v)
        {
            case 'a':
            case 'A':
            case 'e':
            case 'E':
            case 'i':
            case 'I':
            case 'o':
            case 'O':
            case 'u':
            case 'U':
                return 1;
        }
        return 0;
    }
}