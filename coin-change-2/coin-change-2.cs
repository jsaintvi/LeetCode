public class Solution {
    public int Change(int amount, int[] coins) {
        int[] dp = new int[amount + 1];
        dp[0] = 1; // 1 way to make 0 amount is to take no coins
        
        foreach(var coin in coins){
            for(int x = coin; x < amount + 1; x++) {
                dp[x] = dp[x] + dp[x-coin];
            }
        }
        
        return dp[amount];
        
    }
}