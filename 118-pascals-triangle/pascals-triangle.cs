public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var res = new List<IList<int>>(numRows)
        {
            new List<int>(1) { 1 }
        };
        if (numRows == 1)
            return res;
        res.Add(new List<int>(2) { 1, 1 });
        if (numRows == 2)
            return res;

        for (int i = 2; i < numRows; i++)
        {
            int prev = i - 1;
            res.Add(new List<int>(i + 1));

            res[i].Add(1);

            for (int j = 1; j < i; j++)
            {
                res[i].Add(res[prev][j - 1] + res[prev][j]);
            }

            res[i].Add(1);
        }

        return res;
    }
}