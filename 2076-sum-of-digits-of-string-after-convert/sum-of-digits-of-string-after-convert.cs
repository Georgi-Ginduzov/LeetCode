public class Solution {
    public int GetLucky(string s, int k) {
        StringBuilder num = new StringBuilder();
        for(int i = 0; i < s.Length; i++)
        {
            num.Append(s[i] - 96);
        }
        for(int i = 0; i < k; i++)
        {
            int sum = 0;
            for(int j = 0; j < num.Length; j++)
            {
                sum +=num[j]-48;
            }
            num = new StringBuilder(sum.ToString());
        }
        return int.Parse(num.ToString());
    }
}