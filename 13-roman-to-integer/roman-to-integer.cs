public class Solution {
    public int RomanToInt(string s) {
        int num = 0;
        for (int i = 0; i < s.Length; i++)
        {
            switch(s[i])
            {
                case 'I':
                    if(i < s.Length - 1)
                    {
                        if(s[i+1] == 'V')
                        {
                            num += 4;
                            i++;
                        }
                        else if(s[i+1] == 'X')
                        {
                            num += 9;
                            i++;
                        }
                        else
                            num += 1;
                    }
                    else
                        num += 1;
                    break;
                case 'V':
                    num += 5;
                    break;
                case 'X':
                    if(i < s.Length - 1)
                    {
                        if(s[i+1] == 'L')
                        {
                            num += 40;
                            i++;
                        }
                        else if(s[i+1] == 'C')
                        {
                            num += 90;
                            i++;
                        }
                        else
                            num += 10;
                    }
                    else
                        num += 10;
                    break;
                case 'L':
                    num += 50;
                    break;
                case 'C':
                    if(i < s.Length - 1)
                    {
                        if(s[i+1] == 'D')
                        {
                            num += 400;
                            i++;
                        }
                        else if(s[i+1] == 'M')
                        {
                            num += 900;
                            i++;
                        }
                        else
                            num += 100;
                    }
                    else
                        num += 100;
                    break;
                case 'D':
                    num += 500;
                    break;
                case 'M':
                    num += 1000;
                    break;
            }
        }
        return num;
    }
}