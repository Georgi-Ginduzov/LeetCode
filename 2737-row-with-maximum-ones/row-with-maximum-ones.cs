public class Solution {
    public int[] RowAndMaximumOnes(int[][] mat) {
        int[] result = new int[2];
        for(int row = 0; row < mat.Length; row++)
        {
            int ones = 0;
            for(int col = 0; col < mat[row].Length; col++)
            {
                if(mat[row][col] == 1)
                {
                    ones++;
                }
            }
            if(ones > result[1])
            {
                result[1] = ones;
                result[0] = row;
            }
        }
        return result;
    }
}