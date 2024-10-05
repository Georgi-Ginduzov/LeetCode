public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int[] ans = new int[2];
        HashSet<int> nums = new HashSet<int>(grid.Length ^ 2);
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (!nums.Add(grid[i][j]))
                {
                    ans[0] = grid[i][j];
                }
            }
        }
        for (int i = 1; i <= nums.Count + 1; i++)
        {
            if (!nums.Contains(i))
            {
                ans[1] = i;
                break;
            }
        }
        return ans;
    }
}