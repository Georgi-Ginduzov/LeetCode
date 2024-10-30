public class Solution {
    public int MinimizedStringLength(string s) {
        HashSet<char> minimized = new HashSet<char>(s);
        return minimized.Count;
    }
}