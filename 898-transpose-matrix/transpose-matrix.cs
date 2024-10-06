public class Solution {
    public int[][] Transpose(int[][] matrix) {
        int[][] transposed = new int[matrix[0].Length][];
        for(int row = 0; row < matrix[0].Length; row++)
        {
            transposed[row] = new int[matrix.Length];
            for(int col = 0; col < matrix.Length; col++)
            {
                transposed[row][col] = matrix[col][row];
            }
        }
        return transposed;
    }
}