public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();

        Array.Sort(sArray);
        Array.Sort(tArray);

        s = new string(sArray);
        t = new string(tArray);

        Console.WriteLine(s);
        Console.WriteLine(t);
        
        return s == t;
    }
    
}
