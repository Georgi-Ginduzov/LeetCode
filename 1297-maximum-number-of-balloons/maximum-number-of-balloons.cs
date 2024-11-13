public class Solution {
    public int MaxNumberOfBalloons(string text) {
        Dictionary<char, int> balloons = new Dictionary<char, int>
        {
            { 'b', 0 },
            { 'a', 0 },
            { 'l', 0 },
            { 'o', 0 },
            { 'n', 0 }
        };
        for (int i = 0; i < text.Length; i++)
        {
            if (balloons.ContainsKey(text[i]))
            {
                balloons[text[i]]++;
            }
        }
        int occ = 0;
        while (true)
        {
            if(--balloons['b'] == -1)
            {
                return occ;
            }
            if (--balloons['a'] == -1)
            {
                return occ;
            }
            if (--balloons['l'] == -1)
            {
                return occ;
            }
            if (--balloons['l'] == -1)
            {
                return occ;
            }
            if (--balloons['o'] == -1)
            {
                return occ;

            }
            if (--balloons['o'] == -1)
            {
                return occ;

            }
            if (--balloons['n'] == -1)
            {
                return occ;

            }
            occ++;
        }
    }
}