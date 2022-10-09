public class Solution {
    public int ClimbStairs(int n) {
        int[] memo = new int[n+1];
        
        return ClimbStairs(0, n, memo);
    }
    
    private int ClimbStairs(int currStep , int n, int[] memo) {
        if(currStep > n)
            return 0;
        
        if(currStep == n)
            return 1;
        
        if(memo[currStep] > 0)
            return memo[currStep];
        
        memo[currStep] = ClimbStairs(currStep + 1, n, memo) + ClimbStairs(currStep + 2, n, memo);
        
        return memo[currStep];
    }
}