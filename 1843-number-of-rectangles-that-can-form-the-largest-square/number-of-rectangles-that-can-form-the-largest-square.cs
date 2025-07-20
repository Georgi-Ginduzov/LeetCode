public class Solution {
    public int CountGoodRectangles(int[][] rectangles) {
        var map = new SortedDictionary<int, int>();
        foreach(var i in rectangles)
        {
            var square = GetSquareLength(i[0], i[1]);
            if(map.ContainsKey(square))
                map[square]++;
            else
                map.Add(square, 1);
        }

        return map.Values.Last();
    }

    public int GetSquareLength(int length, int width)
        => length > width ? width : length;
}