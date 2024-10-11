public class Solution {
    public string RemoveTrailingZeros(string num) {
        int i = 0;
        while(i < num.Length && num[i] == '0')
        {
            i++;
        }
        int j = num.Length - 1;
        while(j > 0 && num[j] == '0')
        {
            j--;
        }
        return num.Substring(i, num.Length - (num.Length - j) + 1 - i);
    }
}