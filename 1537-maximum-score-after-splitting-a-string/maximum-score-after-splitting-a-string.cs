public class Solution {
    public int MaxScore(string s) {
        int current = s[0] == '0' ? 1 : 0;

        for(int i = 1; i < s.Length; i++)
        {
            if(s[i] == '1')
                current++;
        }

        int max = current;

        for(int i = 1; i < s.Length- 1; i++)
        {
            if(s[i] == '0')
                current++;
            else
                current--;
            max = current > max ? current : max;
        }
        return max;
    }
}