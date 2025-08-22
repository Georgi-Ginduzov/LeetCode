public class Solution {
    public int MaxRepeating(string sequence, string word) {
        string s = word;
        int count = 0;
        while(sequence.Contains(s)){
            count++;
            s+= word;
        }
        return count;
    }
}