public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int[] c = new int[cost.Length+1];
        
        for(int i = 2; i < cost.Length+1; i++)
            c[i] = Math.Min(c[i-1] + cost[i-1], c[i-2] + cost[i-2]);

        return c[cost.Length];
    }
}