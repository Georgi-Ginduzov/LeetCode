public class Solution {
    public string ClearDigits(string s) {
        StringBuilder clean = new StringBuilder(s);
        for(int i = 0; i < clean.Length; i++)
        {
            if(clean[i] - 48 < 10)
            {
                clean.Remove(i-1, 2);
                i = -1;
            }
        }
        return clean.ToString();
    }
}