public class Solution {
    public string MakeGood(string s) {
        StringBuilder good = new StringBuilder(s);
        for(int i = 0; i < good.Length - 1; i++)
        {
            if(Math.Abs(good[i] - good[i+1]) == 'a' - 'A')
            {
                good.Remove(i, 2);
                i -= i > 0 ? 2 : 1;
            }
        }
        return good.ToString();
    }
}