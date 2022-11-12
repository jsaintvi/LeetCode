public class Solution {
    public int MaxProfit(int[] prices) {

        int maxProfit = 0;
        int minPrice = int.MaxValue;
        
        // maintain 2 var: min price (starts at largest int value) and max profit
        for(int i = 0; i < prices.Length; i++) {
            if(prices[i] < minPrice)
                minPrice = prices[i];
            else 
                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
        }
        
        return maxProfit;
    }
}