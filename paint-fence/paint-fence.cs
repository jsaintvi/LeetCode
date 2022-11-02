public class Solution {
    public int NumWays(int n, int k) {
        Dictionary<int,int> memo = new();
        return Dp(n, k, memo);
    }
    
    private int Dp(int i, int k, Dictionary<int,int> memo) {
        if(i==1)
            return k;
        if(i==2) 
            return k*k;
        
        if(memo.ContainsKey(i)){
            return memo[i];
        }
        
        int val =  (k-1) * ( Dp(i-1, k, memo) + Dp(i-2, k, memo));
        memo.Add(i, val);
        
        return memo[i];
    }
}