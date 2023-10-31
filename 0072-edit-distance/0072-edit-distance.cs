public class Solution {
    public int MinDistance(string word1, string word2) {
        int m = word1.Length;
        int n = word2.Length;
        
        int[,] dp = new int[m+1, n+1];
        
        for(int i = 0; i < m+1; i++) {
            for(int j = 0; j < n+1; j++) {
                dp[i,j] = -1;
            }
                
        }
         return   MinDistance(word1, word2, m,n, dp) ;
    }
    
    private int MinDistance(string word1, string word2, int m, int n, int[,] dp) {
        if(m == 0)
            return n;
        if(n== 0)
            return m;
        
        if(dp[m,n] != -1)
            return dp[m,n];
        
        if(word1[m-1] == word2[n-1]) {
            dp[m,n] = MinDistance(word1, word2, m-1, n-1, dp);
        } else{
            dp[m,n] = 1+ Min(
            //Insert
               MinDistance(word1, word2, m, n-1, dp),
            // Delete
                MinDistance(word1, word2, m-1, n, dp),
            // Replace
                MinDistance(word1, word2, m-1, n-1, dp)
            );
        }
           
        return dp[m,n];
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