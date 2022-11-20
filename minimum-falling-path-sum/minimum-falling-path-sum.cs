public class Solution {
    public int MinFallingPathSum(int[][] matrix) {
        int retVal = int.MaxValue;
        
        int m = matrix.Length;
        int n = matrix[0].Length;
        int[,] dp = new int[m+1,n+1];
        
        for(int row = m-1; row >= 0; row--) {
            for(int col = 0; col < n; col++) {
                if(col == 0) {
                    dp[row,col] =  matrix[row][col] + Math.Min(dp[row+1, col], dp[row+1, col+1]);
                } else if(col == n-1) {
                    dp[row,col] =   matrix[row][col] + Math.Min(dp[row+1, col-1], dp[row+1, col]);
                }else{
                    // min of left, middle, right
                    dp[row,col] =  matrix[row][col] +  FindMinOf(new int[]{dp[row+1,col-1], dp[row+1, col], dp[row+1, col+1] });
                }
            }
        }
        // path begins at any cell in ***first row*** qnd ends at ***any cell in last row***
        for(int startCol = 0; startCol < n; startCol++){
            retVal = Math.Min(retVal, dp[0, startCol]);
        }
        
        return retVal;
    }
    
    private int FindMinOf(int[] values){
        int res = int.MaxValue;
        
        foreach(int val in values){
            res = Math.Min(res, val);
        }
        
        return res;
    }
}