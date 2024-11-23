public class Solution {
    public int FindLUSlength(string a, string b) {
        if(a == b)
            return -1;
        return a.Length > b.Length ? a.Length : b.Length;
    }
}