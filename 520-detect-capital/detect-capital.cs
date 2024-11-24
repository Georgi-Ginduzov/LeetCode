public class Solution {
    public bool DetectCapitalUse(string word) {
        return word.Equals(word.ToLower()) || word.Equals(word.ToUpper()) || word.Equals(char.ToUpper(word[0]) + word.Substring(1).ToLower());
    }
}