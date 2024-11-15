public class Solution {
    public bool IsSubstringPresent(string s) {
        HashSet<string> strings = new HashSet<string>();
        for(int i = 0; i < s.Length-1; i++)
        {
            strings.Add(s.Substring(i, 2));
        }
        char[] rev = s.ToCharArray();
        Array.Reverse(rev);
        string reversed = new string(rev);
        for(int i = 0; i < reversed.Length-1; i++)
        {
            if(strings.Contains(reversed.Substring(i, 2)))
                return true;
        }
        return false;
    }
}