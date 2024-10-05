public class Solution {
    public int CountNegatives(int[][] grid) {
        int negatives = 0;
        for(int i = 0; i < grid.Length; i++)
        {
            byte j = 0;
            while(j < grid[i].Length && grid[i][j] >= 0)
            {
                j++;
            }
            negatives += grid[i].Length - j;
        }
        return negatives;
    }
}