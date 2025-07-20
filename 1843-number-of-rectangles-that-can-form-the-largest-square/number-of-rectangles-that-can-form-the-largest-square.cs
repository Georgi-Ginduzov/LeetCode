public class Solution {
    public int CountGoodRectangles(int[][] rectangles) {
        int length = 0;
        int maxSquare = 0;

        foreach(var i in rectangles)
        {
            var square = i[0] > i[1] ? i[1] : i[0];
            if(square > maxSquare)
            {
                length = 1;
                maxSquare = square;
            }
            else if(square == maxSquare)
                length++;
        }

        return length;
    }
}