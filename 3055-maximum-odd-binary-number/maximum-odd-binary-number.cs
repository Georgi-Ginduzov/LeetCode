public class Solution {
    public string MaximumOddBinaryNumber(string s) {
        int ones = 0;
        foreach(var ch in s)
        {
            if(ch == '1')
            {
                ones++;
            }
        }
        StringBuilder result = new StringBuilder();
        for(int i = 0; i < ones - 1; i++)
        {
            result.Append('1');
        }
        for(int i = 0; i < s.Length - ones; i++)
            result.Append('0');
        result.Append('1');
        return result.ToString();
    }
}