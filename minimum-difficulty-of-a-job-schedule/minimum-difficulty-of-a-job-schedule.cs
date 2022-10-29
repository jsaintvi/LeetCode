public class Solution {
    public int MinDifficulty(int[] jobDifficulty, int d) {
        int n = jobDifficulty.Length;
        
        if(n < d) // cant schedule a job per day as we have more days then tasks
            return -1;
        
        int[,]dp = new int[d+1, n+1];
        
        // rows : number of days remaining + 1
        // cols: number of jobdifficulty array + 1
        for(int row = 0; row <= d; row++) {
            for(int col = 0; col < n; col++) {
                dp[row, col] = int.MaxValue;
            }
        }
        
        // rows : number of days remaining + 1
        // cols: number of jobdifficulty array + 1
        for(int row = 1; row <= d; row++) {
            for(int col = 0; col < n - row +1; col++) {
                int dailyMaxJobDiff = 0;
                for(int jobIdx = col+1; jobIdx < n - row+2; jobIdx++) {
                    dailyMaxJobDiff = Math.Max(dailyMaxJobDiff, jobDifficulty[jobIdx-1]);
                    
                    if(dp[row-1, jobIdx] != int.MaxValue) {
                        dp[row, col] = Math.Min(dp[row, col], dailyMaxJobDiff + dp[row-1, jobIdx]);
                    }
                }
            }
        }
        
        return dp[d, 0] ;
    }
    
//     private int MinDiff(int i, int remaingDayCount, int[] jobDifficulty, int[,]memo) {
//         if(memo[i,remaingDayCount] != -1) {
//             return memo[i, remaingDayCount];
//         }
        
//         // base case: last day to complete all jobs, then we must finish all jobs
//         if(remaingDayCount == 1) {
//             int maxJobDifficulty = 0;
//             for(int j = i; j < jobDifficulty.Length; j++) {
//                 maxJobDifficulty = Math.Max(maxJobDifficulty, jobDifficulty[j]);
//             }
            
//             return maxJobDifficulty;
//         }
        
//         int res = int.MaxValue;
//         int dailyMaxJobDiff = 0;
        
//         for(int j = i; j < jobDifficulty.Length - remaingDayCount+1; j++) {
//             dailyMaxJobDiff = Math.Max(dailyMaxJobDiff, jobDifficulty[j]);
            
//             res = Math.Min(res, dailyMaxJobDiff + MinDiff(j+1, remaingDayCount - 1, jobDifficulty, memo));
//         }
        
//         memo[i, remaingDayCount] = res;
//         return res;
//     }
}