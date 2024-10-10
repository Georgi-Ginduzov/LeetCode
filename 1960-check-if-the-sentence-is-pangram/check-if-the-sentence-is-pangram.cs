public class Solution {
    public bool CheckIfPangram(string sentence) {
        var uniques = new HashSet<char>(sentence);
        return uniques.Count >= 26;
    }
}