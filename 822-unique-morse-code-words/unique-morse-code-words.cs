public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        HashSet<string> uniques = new HashSet<string>();
        Dictionary<char, string> morse = new Dictionary<char, string>()
        {
            ['a'] = ".-",
            ['b'] = "-...",
            ['c'] = "-.-.",
            ['d'] = "-..",
            ['e'] = ".", 
            ['f'] = "..-.",
            ['g'] = "--.",
            ['h'] = "....",
            ['i'] = "..",
            ['j'] = ".---",
            ['k'] = "-.-",
            ['l'] = ".-..",
            ['m'] = "--",
            ['n'] = "-.",
            ['o'] = "---",
            ['p'] = ".--.",
            ['q'] = "--.-",
            ['r'] = ".-.",
            ['s'] = "...",
            ['t'] = "-",
            ['u'] = "..-",
            ['v'] = "...-",
            ['w'] = ".--",
            ['x'] = "-..-",
            ['y'] = "-.--",
            ['z'] = "--.."
        };
        for(int i = 0; i < words.Length; i++)
        {
            StringBuilder decoded = new StringBuilder(words[i].Length);
            for(int j = 0; j < words[i].Length; j++)
            {
                decoded.Append(morse[words[i][j]]);
            }
            uniques.Add(decoded.ToString());
        }
        return uniques.Count;
    }
}