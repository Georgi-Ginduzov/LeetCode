public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int[] res = new int[2];
        bool[] rep = new bool[grid.Length*grid.Length];
        res[1] = (rep.Length * (rep.Length + 1)) / 2;

        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(rep[grid[i][j] - 1])
                    res[0] = grid[i][j];
                else
                {
                    rep[grid[i][j] - 1] = true;
                    res[1] -= grid[i][j]; // Calculate missing number
                }
            }
        }

        return res;
    }
}