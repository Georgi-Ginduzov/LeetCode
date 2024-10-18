public class Solution {
    public char RepeatedCharacter(string s) {
        HashSet<char> unique = new HashSet<char>();
        for(int i = 0; i < s.Length - 1; i++)
        {
            if(unique.Add(s[i]) == false)
                return s[i];
        }
        return s[s.Length - 1];
    }
}