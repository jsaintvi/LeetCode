public class Solution {
    public int MinDistance(string word1, string word2) {
        int m = word1.Length;
        int n = word2.Length;
        
        int[,] dp = new int[m+1, n+1];
        
        for(int row = 0; row < m+1; row++)
            dp[row,0] = row;
        
        for(int col = 0; col < n+1; col++)
            dp[0, col] = col;
        
        for(int row = 1; row < m+1; row++) {
            for(int col = 1; col < n+1; col++) {
                if(word1[row-1] == word2[col-1]) {
                    dp[row,col] = dp[row-1, col-1];
                } else {
                    dp[row,col] = 1 + Min(
                        // INSERT
                        dp[row, col-1], 
                        // Delete
                        dp[row-1, col],
                        // Replace
                        dp[row-1,col-1]
                    );
                }
            }
        }
         return  dp[m,n];
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