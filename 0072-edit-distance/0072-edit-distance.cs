public class Solution {
    public int MinDistance(string word1, string word2) {
        int m = word1.Length;
        int n = word2.Length;
        int[,] dp = new int[m+1,n+1];
        
        // intialize row 0 and COL 0 to 0
        for(int row = 0; row <= m; row++) {
            dp[row, 0] = row;
        }
        
        for(int col = 0; col <= n; col++) {
            dp[0, col] = col;
        }
        
        for(int row = 1; row <= m; row++) {
            for(int col = 1; col <= n; col++) {
                if(word1[row-1] == word2[col-1]) {
                    dp[row, col] = dp[row - 1, col - 1];
                } else {
                    // --------------------------------------------------------------------
                    //| We need to explore all 3 options: 
                    //| 1 - INSERT: MinDIstance(word1, word2, m, n-1) 
                    //| 2 - DELETE: MinDIstance(word1, word2, m - 1, n)  
                    //| 3 - REPLACE: (MinDistance(word1, word2, m-1, n-1))
                    //---------------------------------------------------------------------
                    dp[row, col] = 1 + Min(dp[row, col-1], dp[row-1, col], dp[row-1, col-1]);
                }
            }
        }
        
        return dp[m, n];      
    }
     
    private int Min(params int[] vals) {
        int min = int.MaxValue;
        foreach(var val in vals){
            if(val < min) {
                min = val;
            }
        }
        
        return min;
    }
}