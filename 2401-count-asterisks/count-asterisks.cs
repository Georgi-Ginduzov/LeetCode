public class Solution {
    public int CountAsterisks(string s) {
        int ast = 0;
        for(int i = 0; i < s.Length; i++)
        {
            switch(s[i])
            {
                case '*':
                    ast++;
                    break;
                case '|':
                    while(++i < s.Length && s[i] != '|')
                    {

                    }
                    break;
            }
                
        }
        return ast;
    }
}