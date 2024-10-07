public class Solution {
    public string ToLowerCase(string s) {
        StringBuilder lowercase = new StringBuilder();
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] >= 65 && s[i] <= 90)
            {
                lowercase.Append((char)(s[i] + 32));
            }
            else
            {
                lowercase.Append(s[i]);
            }
        }
        return lowercase.ToString();
    }
}