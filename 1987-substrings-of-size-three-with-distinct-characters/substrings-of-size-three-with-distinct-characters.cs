public class Solution {
    public int CountGoodSubstrings(string s) {
        int good = 0;
        for(int i = 0; i < s.Length - 2; i++)
        {
            HashSet<char> substr = new HashSet<char>(s.Substring(i, 3));
            good += substr.Count == 3 ? 1 : 0;
        }
        return good;
    }
}