public class Solution {
    public string FinalString(string s) {
        List<char> res = new List<char>();
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == 'i')
            {
                res.Reverse();
            }
            else
            {
                res.Add(s[i]);
            }
        }
        return string.Join(string.Empty, res);
    }
}