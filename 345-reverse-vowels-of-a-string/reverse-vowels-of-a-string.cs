public class Solution {
    public string ReverseVowels(string s) {
        StringBuilder reversed = new StringBuilder(s);
        int r = s.Length - 1;
        for(int i = 0; i < r; i++)
        {
            if(IsVowel(s[i]))
            {
                while(r > i && IsVowel(s[r]) == false)
                {
                    r--;
                }
                if (r > i) 
                {
                    char temp = reversed[i];
                    reversed[i] = reversed[r];
                    reversed[r] = temp;
                    r--;
                }
            }
        }
        return reversed.ToString();
    }
    public static bool IsVowel(char l)
    {
        switch(l)
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
                return true;
            default:
                return false;
        }
    }
}