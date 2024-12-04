public class Solution {
    public int LengthOfLastWord(string s) {
        int lastWordLength = 0;
        for(int i = 0; i < s.Length; i++)
        {
            int currentLength = 0;
            if(s[i] == ' ')
                continue;
            for(int j = i; j < s.Length; j++, i++)
            {
                if(s[j] != ' ')
                {
                    currentLength++;
                }
                else
                    break;
            }
            lastWordLength = currentLength;
        }
        return lastWordLength;
    }
}