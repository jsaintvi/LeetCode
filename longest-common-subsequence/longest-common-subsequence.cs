public class Solution {
    private string text1;
    private string text2;
    public int LongestCommonSubsequence(string text1, string text2) {
        int text1Len = text1.Length;
        int text2Len = text2.Length;
        
        this.text1 = text1;
        this.text2 = text2;
        
        int[,] memo = new int[text1Len+1, text2Len+1];
        
        for(int i = 0; i < text1Len; i++) {
            for(int j = 0; j < text2Len; j++) {
               memo[i,j] = -1; 
            }
        }
        return DP(0,0, memo);
        
        
    }
    

    private int DP(int i, int j, int[,] memo){
        if(memo[i,j] != -1)
            return memo[i,j];
        
        int ans = 0;
        if( text1[i] == text2[j] ) {
            ans = 1 + DP(i+1, j+1, memo);
        }else{
            // char not the same, then either one or both of those chars will not be used in the final answer
            ans = Math.Max(DP(i, j+1, memo), DP(i+1, j, memo));
        }
        
        memo[i,j] = ans;
        return memo[i,j];
    }
}