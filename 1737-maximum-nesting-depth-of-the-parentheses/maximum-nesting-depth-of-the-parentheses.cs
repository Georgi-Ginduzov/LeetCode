public class Solution {
    public int MaxDepth(string s) {
        int max = 0;
        int current = 0;
        for(int i = 0; i < s.Length; i++)
        {
            switch(s[i])
            {
                case '(':
                    current++;
                    break;
                case ')':
                    current--;
                    break;
                default:
                    continue;
            }
            max = Math.Max(max, current);
        }
        return max;
    }
}