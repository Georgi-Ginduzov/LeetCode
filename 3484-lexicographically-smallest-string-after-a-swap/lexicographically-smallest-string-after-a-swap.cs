public class Solution {
    public string GetSmallestString(string s) {
        char[] num = s.ToCharArray();
        for(int i = 0; i < num.Length - 1; i++)
        {
            if(num[i] % 2 == num[i+1] % 2 && num[i] > num[i+1])
            {
                (num[i],num[i+1]) = (num[i+1],num[i]);
                return new string(num);
            }
        }
        
        return new string(num);
    }
}