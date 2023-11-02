# Thought process
How to get to n step, we can take 1 step or 2 steps.

To get to step 1, we can do so in 1 way. To get to step 2, we can either take 1 step at a time, or 2 steps to get to it. 

Think of it this way , we can reach the ith stair from the (i-1)th stair and the (i-2)th stair by taking 1 and 2 steps, respectively. So the total number of ways to reach the ith stair is equal to  the total number of ways to reach the (i-1)th stair + total number of ways to reach the (i-2)th stair.  
`climbingStairs(n) = climbingStairs(n-1) + climbingStairs(n-2)`

## Pseudocode
```c#
    int climbingStairs(int n) {
        int[] dp = new int[n+1]; // n+ 1 subproblems
        dp[1] = 1; // 1 way to get to first stair
        dp[2] = 2; // 2 ways to get to stair 2 (1-1 | 2)
        
        for(int i = 3; i <= n; i++)
            dp[i] = dp[i-1] + dp[i-2];
        
        return dp[n]
    }
```