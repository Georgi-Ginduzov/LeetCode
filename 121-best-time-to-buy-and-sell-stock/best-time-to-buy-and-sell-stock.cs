public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length == 1)
            return 0;
        
        int profit = 0;
        int buyAt = 0;
        int sellAt = 1;
        while(sellAt < prices.Length)
        {
            if(prices[buyAt] < prices[sellAt])
                profit = Math.Max(profit, prices[sellAt] - prices[buyAt]);
            else
                buyAt = sellAt;
            
            sellAt++;
        }

        return profit;
    }
}