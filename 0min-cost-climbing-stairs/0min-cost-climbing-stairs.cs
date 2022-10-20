public class Solution {
    public int MinCostClimbingStairs(int[] cost) {

        int[] dp = new int[cost.Length+1]; // +1 to treat the top floor as the step to reach.
        dp[0] = 0;
        dp[1] = 0;
        
        int n = dp.Length;
        for(int i = 2; i < n; i++) {
            int takeOneStep = cost[i-1] + dp[i-1];
            int takeTwoStep = cost[i-2] + dp[i-2];
            
            dp[i] = Math.Min(takeOneStep, takeTwoStep);
        }
        
        return dp[n-1];
    }
}