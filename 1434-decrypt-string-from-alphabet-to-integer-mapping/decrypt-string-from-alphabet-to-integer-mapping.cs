public class Solution {
    public string FreqAlphabets(string s) {
        Stack<char> decrypted = new Stack<char>();
        for(int i = s.Length - 1; i >= 0; i--)
        {
            if(s[i] == '#')
            {
                decrypted.Push((char)(('a'- 1) + ((s[--i] - '0') + (10 * (s[--i] - '0')))));
            }
            else
                decrypted.Push((char)(('a'-1) + s[i] - '0'));
        }
        return new string(decrypted.ToArray());
    }
}