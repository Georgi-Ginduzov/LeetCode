public class Solution {
    public string GenerateTheString(int n) {
        char[] str = new char[n];
        if(n < 27)
        {
            for(int i = 0; i < n; i++)
            {
                str[i] = (char)('a' + i);
            }
        }
        else
        {
            if(n % 2 == 0)
            {
                for(int i = 0; i < 25; i++)
                {
                    str[i] = (char)('a' + i);
                }
                for(int i = 25; i < n; i++)
                {
                    str[i] = 'z';
                }
            }
            else
            {
                for(int i = 0; i < 24; i++)
                {
                    str[i] = (char)('a' + i);
                }
                for(int i = 24; i < n; i++)
                {
                    str[i] = 'z';
                }
            }
        }
        return new string(str);
    }
}