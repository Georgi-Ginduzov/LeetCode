public class Solution {
    public int NumOfStrings(string[] patterns, string word) {
        return patterns.Count(p => word.Contains(p));
    }
}