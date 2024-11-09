public class Solution {
    public string CapitalizeTitle(string title) {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < title.Length; i++)
        {
            int letters = 0;
            while (i + letters < title.Length && title[i + letters] != ' ')
            {
                result.Append(title[i + letters] < 'a' ? (char)(title[i + letters] + 32) : title[i + letters]);
                letters++;
            }
            if (letters > 2)
            {
                result[i] = title[i] < 'a' ? (char)title[i] : (char)(title[i] - 32);
            }
            i += letters;
            if (i >= title.Length)
                break;
            result.Append(' ');
        }
        return result.ToString();
    }
}