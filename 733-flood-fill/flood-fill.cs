/*
    To perform a flood fill:

    Begin with the starting pixel and change its color to color.
        - no need for checks, just change it

    Perform the same process for each pixel that is directly adjacent (pixels that share a side with the original pixel, 
    either horizontally or vertically) and shares the same color as the starting pixel.
        - store steps
        - Make a step by checking if it is inbound and equal to the original el's value
        - For each step:
            - remove it
            - change its colour 
        finally return the image

    Keep repeating this process by checking neighboring pixels of the updated pixels and modifying their color 
    if it matches the original color of the starting pixel.

    The process stops when there are no more adjacent pixels of the original color to update.
    
    Return the modified image after performing the flood fill.
        - Modify the image array
*/
public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if(image[sr][sc] == color)
            return image;
        var q = new Queue<(int row, int col)>();
        q.Enqueue((sr, sc));
        var val = image[sr][sc];
        while(q.Any())
        {
            var el = q.Dequeue();
            image[el.row][el.col] = color;
            
            int row = el.row;
            int col = el.col;
            row--;// Check upside
            if(row >= 0 && image[row][col] == val)
                q.Enqueue((row, col));
            row += 2;// Check down
            if(row < image.Length && image[row][col] == val)
                q.Enqueue((row, col));
            row--; // reset row value
            col--;// Check left
            if(col >= 0 && image[row][col] == val)
                q.Enqueue((row, col));
            col+=2;// Check right
            if(col < image[row].Length && image[row][col] == val)
                q.Enqueue((row, col));
        }
        return image;
    }
}