public class Solution {
    public string[] UncommonFromSentences(string s1, string s2) {
        Dictionary<string, int> words = new Dictionary<string, int>();
        int from = 0;
        int i = 0;
        while(i < s1.Length)
        {
            if(s1[i] == ' ')
            {
                if(!words.TryAdd(s1.Substring(from, i - from), 1))
                {
                    words[s1.Substring(from, i - from)]++;
                }
                from = i + 1;
            }
            i++;
        }
        if(!words.TryAdd(s1.Substring(from, i - from), 1))
        {
            words[s1.Substring(from, i - from)]++;
        }
        i = 0;
        from = 0;
        while(i < s2.Length)
        {
            if(s2[i] == ' ')
            {
                if(!words.TryAdd(s2.Substring(from, i - from), 1))
                {
                    words[s2.Substring(from, i - from)]++;
                }
                from = i + 1;
            }
            i++;
        }
        if(!words.TryAdd(s2.Substring(from, i - from), 1))
        {
            words[s2.Substring(from, i - from)]++;
        }
        List<string> result = new List<string>();
        foreach(var pair in words)
        {
            if(pair.Value == 1)
            {
                result.Add(pair.Key);
            }
        }
        return result.ToArray();
    }
}