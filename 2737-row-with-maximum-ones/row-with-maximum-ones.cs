public class Solution {
    public int[] RowAndMaximumOnes(int[][] mat) {
        var res = new int[2];

        for(int i = 0; i < mat.Length; i++)
        {
            int rowSum = mat[i].Sum();
            if (rowSum <= res[1])
                continue;
            
            res[0] = i;
            res[1] = rowSum;
        }

        return res;
    }
}