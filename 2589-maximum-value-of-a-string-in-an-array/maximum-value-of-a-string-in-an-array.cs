public class Solution {
    public int MaximumValue(string[] strs) {
        int max = 0;
        foreach(var word in strs)
        {
            int i = 0;
            while(i < word.Length)
            {
                if(word[i] - 48 > 9)
                {
                    max = Math.Max(max, word.Length);
                    i = word.Length;
                }
                i++;
            }
            if(i <= word.Length)
            {
                max = Math.Max(max, int.Parse(word));
            }
        }
        return max;
    }
}