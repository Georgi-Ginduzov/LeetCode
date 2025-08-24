/**
Given an integer numRows, return the first numRows of Pascal's triangle.
    - build a pascals triangle 
    - return it

In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
    - i have to make calculations from the 2nd to n-2nd elements
        - always 0th and n-1st elements are 1s
    - calculate a row
        - get elements from the previous row
        - ith element = i-1th element + the ith element, from the prev row


*/
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var p = new List<IList<int>>(numRows);
        switch(numRows)
        {
            case 1:
                p.Add(new List<int>(1){1});
                return p;
            case 2:
                p.Add(new List<int>(1){1});
                p.Add(new List<int>(2){1,1});
                return p;
        }

        p.Add(new List<int>(1){1});
        p.Add(new List<int>(2){1,1});

        for(int row = 2; row < numRows; row++)
        {
            p.Add(new List<int>(row+1));
            p[row].Add(1);
            for(int i = 1; i < row; i++)
            {
                p[row].Add(p[row-1][i-1] + p[row-1][i]);
            }
            p[row].Add(1);
        }
        return p;
    }
}