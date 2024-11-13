public class Solution {
    public int[] NumberOfLines(int[] widths, string s) {
        int[] result = new int[2];
        result[0] = 1;
        int sum = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(sum + widths[s[i]-'a'] > 100)
            {
                result[0]++;
                sum = 0;
            }
            sum += widths[s[i]-'a'];
        }
        result[1] = sum;
        return result;
    }
}