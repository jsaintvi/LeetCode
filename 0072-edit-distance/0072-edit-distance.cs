public class Solution {
    public int MinDistance(string word1, string word2) {
        int m = word1.Length;
        int n = word2.Length;
        int[,] dp = new int[m+1,n+1];
        
        for(int i = 0; i <= m; i++) {
            for(int j = 0; j <= n; j++) {
                dp[i,j] = -1;
            }
        }
            
        return MinDistance(word1, word2, m, n, dp);
    }
    
    private int MinDistance(string word1, string word2, int m, int n, int[,] dp) {
        // TO transform 1 string into empty string, we delete all its chars. Same way, to transform an EMPTY string into non-empty string
        if(m == 0) { // empty
            return n;
        }
        
        if( n == 0) {
            return m;
        }
        
        var key = $"{m}-{n}";
        if(dp[m,n] != -1) {
            return dp[m,n];
        }
        
        //map.Add(key, -1);
        
        if(word1[m-1] == word2[n-1]) { // chars are equal
            dp[m,n] =  MinDistance(word1, word2, m-1, n-1, dp);
        } else {
            // --------------------------------------------------------------------
            //| We need to explore all 3 options: 
            //| 1 - INSERT: MinDIstance(word1, word2, m, n-1) 
            //| 2 - DELETE: MinDIstance(word1, word2, m - 1, n)  
            //| 3 - REPLACE: (MinDistance(word1, word2, m-1, n-1))
            //---------------------------------------------------------------------
            
            dp[m,n] =  1 + Min(
                MinDistance(word1, word2, m, n-1, dp),
                MinDistance(word1, word2, m - 1, n, dp),
                MinDistance(word1, word2, m - 1, n-1, dp)
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