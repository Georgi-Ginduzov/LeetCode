public class Solution {
    public bool AreOccurrencesEqual(string s) {
        Dictionary<char, int> chars = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++)
        {
            if(chars.ContainsKey(s[i]))
            {
                chars[s[i]]++;
            }
            else
            {
                chars.Add(s[i], 1);
            }
        }
        int occurrencies = chars.First().Value;
        foreach(var pair in chars)
        {
            if(pair.Value != occurrencies)
                return false;
        }
        return true;
    }
}