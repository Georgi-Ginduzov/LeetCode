public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        Span<bool> visited = stackalloc bool[image.Length * image[0].Length];
        int initialColor = image[sr][sc];
        if (initialColor == color)
            return image;
        
        var adjacent = new Queue<(int row, int col)>();
        adjacent.Enqueue((sr, sc));
        visited[image[sr].Length * sr + sc] = true;

        while(adjacent.Count > 0)
        {
            var cell = adjacent.Dequeue();
            image[cell.row][cell.col] = color;

            cell.col++; // go right
            if(cell.col < image[cell.row].Length 
                && image[cell.row][cell.col] == initialColor
                && !visited[image[cell.row].Length * cell.row + cell.col])
            {
                adjacent.Enqueue(cell);
                visited[image[cell.row].Length * cell.row + cell.col] = true;
            }

            cell.col--; // return left
            cell.row++; // go down
            if(cell.row < image.Length 
                && image[cell.row][cell.col] == initialColor
                && !visited[image[cell.row].Length * cell.row + cell.col])
            {
                adjacent.Enqueue(cell);
                visited[image[cell.row].Length * cell.row + cell.col] = true;
            }

            cell.row--; // return up
            cell.col--; // go left
            if(cell.col >= 0 
                && image[cell.row][cell.col] == initialColor
                && !visited[image[cell.row].Length * cell.row + cell.col])
            {
                adjacent.Enqueue(cell);
                visited[image[cell.row].Length * cell.row + cell.col] = true;
            }

            cell.col++; // return right
            cell.row--; // go up
            if(cell.row >= 0 
                && image[cell.row][cell.col] == initialColor
                && !visited[image[cell.row].Length * cell.row + cell.col])
            {
                adjacent.Enqueue(cell);
                visited[image[cell.row].Length * cell.row + cell.col] = true;
            }
        }

        return image;
    }
}