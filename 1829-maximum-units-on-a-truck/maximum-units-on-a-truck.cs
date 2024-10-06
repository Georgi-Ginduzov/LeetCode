public class Solution {
    public int MaximumUnits(int[][] boxTypes, int truckSize) {
        Array.Sort(boxTypes, (a, b) => b[1].CompareTo(a[1]));
        int totalUnits = 0;
        for(int i = 0; i < boxTypes.Length; i++)
        {
            totalUnits += Math.Min(truckSize, boxTypes[i][0]) * boxTypes[i][1];
            truckSize -= Math.Min(truckSize, boxTypes[i][0]);
            
            if (truckSize == 0) {
                return totalUnits;
            }
        }
        return totalUnits;
    }
}