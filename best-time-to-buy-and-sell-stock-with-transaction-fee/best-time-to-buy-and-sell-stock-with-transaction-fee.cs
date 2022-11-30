public class Solution {
    public int MaxProfit(int[] prices, int fee) {

        // initial profit and hold on day 0
        int cash = 0; 
        int hold = -prices[0];
        
        for(int i = 1; i < prices.Length; i++) {
            // buy or sell
            cash = Math.Max(cash, hold + prices[i] - fee);
            
            // continue holding stock or sell
            hold = Math.Max(hold, cash - prices[i]);
        }
        
        return cash;
        
    }
}