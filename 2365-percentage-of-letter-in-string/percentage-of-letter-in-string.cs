public class Solution {
    public int PercentageLetter(string s, char letter) {
        int occurrence = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == letter)
                occurrence++;
        }
        return ((int)(((double)occurrence / s.Length) * 100));
    }
}