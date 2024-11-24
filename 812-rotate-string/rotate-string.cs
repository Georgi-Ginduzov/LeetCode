public class Solution {
    public bool RotateString(string s, string goal) {
        if(s.Length != goal.Length)
            return false;
        string concatenated = s + s;
        return concatenated.Contains(goal);
    }
}