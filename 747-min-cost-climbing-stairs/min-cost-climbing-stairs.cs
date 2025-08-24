public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int n = cost.Length+1;
        int[] c = new int[n];
        
        for(int i = 2; i < n; i++)
            c[i] = Math.Min(c[i-1] + cost[i-1], c[i-2] + cost[i-2]);

        return c[cost.Length];
    }
}