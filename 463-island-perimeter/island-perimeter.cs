public class Solution {
    public int IslandPerimeter(int[][] grid) {
        Span<bool> visited = stackalloc bool[grid.Length * grid[0].Length];
        int perimeter = 0;
        var lands = new Queue<(int row, int col)>();
        var landBeginning = FindFirstLand(grid);
        if(landBeginning.x is -1)
            return 0;

        lands.Enqueue(landBeginning);
        visited[(grid[landBeginning.x].Length * landBeginning.x) + landBeginning.y] = true;

        while(lands.Count > 0)
        {
            var neighbour = lands.Dequeue();
            int waterTiles = 4;

            neighbour.row--; // Check upper cell
            if(neighbour.row >= 0 && IsLand(grid, neighbour))
            {
                waterTiles--;
                if(!visited[(grid[neighbour.row].Length * neighbour.row) + neighbour.col])
                {
                    lands.Enqueue(neighbour);
                    visited[(grid[neighbour.row].Length * neighbour.row) + neighbour.col] = true;
                }
            }
            
            neighbour.row++; // Recover original row
            neighbour.col--; // Check left cell
            if(neighbour.col >= 0 && IsLand(grid, neighbour))
            {
                waterTiles--;
                if(!visited[(grid[neighbour.row].Length * neighbour.row) + neighbour.col])
                {
                    lands.Enqueue(neighbour);
                    visited[(grid[neighbour.row].Length * neighbour.row) + neighbour.col] = true;
                }
            }
            
            neighbour.col++; // Recover original col
            neighbour.row++; // Check downward cell
            if(neighbour.row < grid.Length && IsLand(grid, neighbour))
            {
                waterTiles--;
                if(!visited[(grid[neighbour.row].Length * neighbour.row) + neighbour.col])
                {
                    lands.Enqueue(neighbour);
                    visited[(grid[neighbour.row].Length * neighbour.row) + neighbour.col] = true;
                }
            }
            
            
            neighbour.row--; // Recover original row
            neighbour.col++; // Check right cell
            if(neighbour.col < grid[neighbour.row].Length && IsLand(grid, neighbour))
            {
                waterTiles--;
                if(!visited[(grid[neighbour.row].Length * neighbour.row) + neighbour.col])
                {
                    lands.Enqueue(neighbour);
                    visited[(grid[neighbour.row].Length * neighbour.row) + neighbour.col] = true;
                }
            }
            
            perimeter += waterTiles;
        }
        
        return perimeter;
    }

    private (int x, int y) FindFirstLand(int[][] grid)
    {
        for(int row = 0; row < grid.Length; row++)
            for(int col = 0; col < grid[row].Length; col++)
                if(grid[row][col] is 1)
                    return (row, col);
        return (-1, -1);
    }

    // Return if the neighbour is land
    private bool IsLand(int[][] grid, (int row, int col) newCoords)
        => grid[newCoords.row][newCoords.col] is 1;
}