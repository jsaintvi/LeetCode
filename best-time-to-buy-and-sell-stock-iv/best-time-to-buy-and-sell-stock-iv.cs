public class Solution {
    public int MaxProfit(int k, int[] prices) {
        int[,,] memo = new int[prices.Length + 1, k+1, 2];
        return Dp(prices, 0, k, 0, memo);
    }
    
    private int Dp(int[]prices, int currDay, int transactionRemaining, int holding, int[,,]memo) {
       // base cases
        if(transactionRemaining == 0 || currDay == prices.Length)
            return 0;
        
        if(memo[currDay, transactionRemaining, holding] == 0){
            // choose whether to do nothing or whether to do something (i.e sell or buy)
            
            int doNothing = Dp(prices, currDay + 1, transactionRemaining, holding, memo);
            
            int doSomething;
            
            if(holding == 1) {
                // sell
                doSomething = prices[currDay] +  Dp(prices, currDay + 1, transactionRemaining - 1, 0, memo);
            } else { //buy
                doSomething = Dp(prices, currDay + 1, transactionRemaining , 1, memo) - prices[currDay];
            }
            
            memo[currDay, transactionRemaining, holding] = Math.Max(doNothing, doSomething);
        }
        
        return memo[currDay, transactionRemaining, holding];
    }
}