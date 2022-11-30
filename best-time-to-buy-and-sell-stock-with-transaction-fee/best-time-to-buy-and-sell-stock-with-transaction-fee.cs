public class Solution {
    public int MaxProfit(int[] prices, int fee) {
        // on day 0
        var buyPrev = -prices[0]; // buy
        var notBuyPrev = 0; //sell
        
        for(var i = 1; i < prices.Length; i++)
        {  
            var price = prices[i];
            
            var buyStock = notBuyPrev - price;
            var sellStock = price + buyPrev - fee;
            
            buyPrev = Math.Max(buyPrev, buyStock);
            notBuyPrev = Math.Max(notBuyPrev, sellStock);
        }
        
        return Math.Max(buyPrev, notBuyPrev);
        
    }
}