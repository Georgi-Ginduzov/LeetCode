public class Solution {
    public string SortString(string s) {
        int[] charCount = new int[26];
        foreach (char c in s) {
            charCount[c - 'a']++;
        }
        StringBuilder result = new StringBuilder();
        int remaining = s.Length;
        while (remaining > 0) {
            for (int i = 0; i < 26; i++) {
                if (charCount[i] > 0) {
                    result.Append((char)(i + 'a'));
                    charCount[i]--;
                    remaining--;
                }
            }
            for (int i = 25; i >= 0; i--) {
                if (charCount[i] > 0) {
                    result.Append((char)(i + 'a'));
                    charCount[i]--;
                    remaining--;
                }
            }
        }
        return result.ToString();
    }
}