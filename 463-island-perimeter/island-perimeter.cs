public class Solution {
    public int IslandPerimeter(int[][] grid) {
        var visited = new bool[grid.Length, grid[0].Length];
        
        for(int i = 0; i < grid.Length; i++)
            for(int j = 0; j < grid[i].Length; j++)
                if(grid[i][j] == 1)
                    return (LandPerimeter(i, j));

        return 0;

        int LandPerimeter(int x, int y)
        {
            if(x < 0 || x >= grid.Length || y < 0 || y >= grid[x].Length)
                return 1;
            
            if(grid[x][y] == 0)
                return 1;
            
            if(visited[x,y])
                return 0;
            
            visited[x,y] = true;

            return LandPerimeter(x+1, y) + LandPerimeter(x-1, y) + LandPerimeter(x,y+1) + LandPerimeter(x,y-1);
        }
    }
}