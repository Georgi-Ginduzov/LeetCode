public class Solution {
    public string ReversePrefix(string word, char ch) {
        int chLocation = -1;
        for(int i = 0; i < word.Length; i++)
        {
            if(word[i] == ch)
            {
                chLocation = i;
                break;
            }
        }
        if(chLocation == -1)
        {
            return word;
        }
        char[] reversed = word.ToCharArray();
        for(int i = 0; i < (chLocation + 1) / 2; i++)
        {
            char buff = reversed[i];
            reversed[i] = reversed[chLocation - i];
            reversed[chLocation - i] = buff;
        }
        return new string(reversed);
    }
}