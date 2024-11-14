public class Solution {
    public string[] DivideString(string s, int k, char fill) {
        int numGroups = (s.Length + k - 1) / k;
        string[] str = new string[numGroups];
        
        for (int i = 0; i < numGroups; i++) {
            int start = i * k;
            int length = Math.Min(k, s.Length - start);
            string part = s.Substring(start, length);

            if (part.Length < k) {
                part = part.PadRight(k, fill);
            }
            
            str[i] = part;
        }

        return str;
    }
}