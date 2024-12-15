public class Solution {
    public int NumberOfPoints(IList<IList<int>> nums) {
        bool[] points = new bool[102];
        for(int i = 0; i < nums.Count; i++)
        {
            for(int j = nums[i][0]; j <= nums[i][1]; j++)
            {
                points[j] = true;
            }
        }
        int pointsSum = 0;
        for(int i = 0; i < points.Length; i++)
        {
            if(points[i])
                pointsSum++;
        }
        return pointsSum;
    }
}