public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] letters = new int[26];
        for(int i = 0; i < magazine.Length; i++)
        {
            letters[magazine[i] - 'a']++;
        }
        for(int i = 0; i < ransomNote.Length; i++)
        {
            if(--letters[ransomNote[i]-'a'] == -1)
                return false;
        }
        return true;
    }
}