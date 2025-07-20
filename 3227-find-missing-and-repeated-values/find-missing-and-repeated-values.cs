public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int[] res = new int[2];
        Span<bool> rep = stackalloc bool[grid.Length*grid.Length + 1];
        res[1] = ((rep.Length - 1) * rep.Length) / 2;

        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(rep[grid[i][j]])
                    res[0] = grid[i][j];
                else
                {
                    rep[grid[i][j]] = true;
                    res[1] -= grid[i][j]; // Calculate missing number
                }
            }
        }

        return res;
    }
}