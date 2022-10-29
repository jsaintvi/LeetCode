public class Solution {
    public int CoinChange(int[] coins, int amount) {
        
        if(amount == 0) return 0;                
        
        int[] dp = new int[amount+1];
        
        for(int i = 0; i < dp.Length; i++) {
            dp[i] = amount+1;
        }
        
        dp[0] = 0;
        
        for(int  i = 1; i <= amount; i++) {
            for(int j = 0; j < coins.Length; j++) {
                if(coins[j] <= i) {
                    dp[i] = Math.Min(dp[i], dp[i-coins[j]] +1);
                }
            }
        }
        
        return dp[amount] > amount ? -1 : dp[amount];
    }
}