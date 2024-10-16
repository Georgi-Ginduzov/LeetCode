public class Solution {
    public int CountKeyChanges(string s) {
        int changes = 0;
        for(int i = 1; i < s.Length; i++)
        {
            if(s[i]%32 == s[i-1]%32)
            {

            }
            else
            {
                changes++;
            }
        }
        return changes;
    }
}