public class Solution {
    public IList<string> CellsInRange(string s) {
        List<string> cells = new List<string>();
        if(s[1] == s[4])
        {
            for(int i = s[0]; i <= s[3]; i++)
            {
                cells.Add($"{(char)i}{s[1]}");
            }
        }
        else
        {
            for(int i = s[0]; i <= s[3]; i++)
            {
                for(int j = s[1]-48; j <= s[4] - 48; j++)
                {
                    cells.Add($"{(char)i}{j}");
                }
            }
        }
        return cells;
    }
}