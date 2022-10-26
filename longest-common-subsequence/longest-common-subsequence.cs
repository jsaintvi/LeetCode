public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int text1Len = text1.Length;
        int text2Len = text2.Length;
        
        int[,] memo = new int[text1Len+1, text2Len+1];

        for(int col = text2Len-1; col >= 0; col--) {
            for(int row = text1Len-1; row>= 0; row--) {
                if( text1[row] == text2[col] ){ // add 1
                    memo[row,col] = 1 + memo[row+1,col+1];
                }else{ // chars are different
                    memo[row,col] = Math.Max( memo[row+1, col], memo[row, col+1] );
                }
            }
        }
        
        return memo[0,0];
        
    }
}