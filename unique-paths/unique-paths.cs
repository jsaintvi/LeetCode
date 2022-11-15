public class Solution {
    public int UniquePaths(int m, int n) {
       int[,] memo = new int[m,n];
        
        return Dp(m-1, n-1, memo);
    }
    
    private int Dp(int m, int n, int[,] memo){
        if(m == 0 || n == 0)
        {
            memo[m,n]=1;
            return memo[m,n];
        }
        
        if(memo[m,n] != 0)return memo[m,n];
        
        memo[m,n]= Dp(m-1, n, memo) + Dp(m, n-1, memo);
        return memo[m,n];
    }
}