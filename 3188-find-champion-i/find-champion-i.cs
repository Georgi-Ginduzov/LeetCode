public class Solution {
    public int FindChampion(int[][] grid) {
        HashSet<int> teams = new HashSet<int>();
        for(int i = 0; i < grid.Length; i++)
        {
            teams.Add(i);
        }
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(j == i)
                    continue;
                if(grid[i][j] == 1)
                {
                    teams.Remove(j);
                    if(teams.Count == 1)
                    {
                        return teams.First();
                    }                    
                }
            }
        }
        return teams.First();
    }
}