public class Solution {
    public int NumberOfSpecialChars(string word) {
        bool[] letters = new bool[52];
        for(int i = 0; i < word.Length; i++)
        {
            letters[word[i] > 'Z' ? word[i] - 'a' : word[i] - 'A' + 26] = true;
        }
        int special = 0;
        for(int i = 0; i < letters.Length/2; i++)
        {
            if(letters[i] == true && letters[i+26] == true)
                special++;
        }
        return special;
    }
}