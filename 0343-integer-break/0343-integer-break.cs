public class Solution {
    public int IntegerBreak(int n) {
        if (n <= 1) return 0;
        
        // dp[i] stores the maximum product for integer i
        int[] dp = new int[n + 1];
        dp[1] = 1;
        
        // Iterate through integers from 2 to n
        for (int i = 2; i <= n; i++) {
            // Iterate through all possible partitions of i into two integers j and i - j
            for (int j = 1; j < i; j++) {
                // Calculate the product of the two integers
                // We can either choose j * (i - j) or j * dp[i - j] to get the maximum product
                dp[i] = Math.Max(dp[i], Math.Max(j * (i - j), j * dp[i - j]));
            }
        }
        
        return dp[n];
    }
}