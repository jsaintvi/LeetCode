public class Solution {
    public int MaximalSquare(char[][] matrix) {
        int rowCount = matrix.Length;
        int colCount = matrix[0].Length;
        
        int[,] dp = new int[rowCount + 1, colCount + 1];
        
        int maxSqlLenSoFar = 0;
        for(int row = 1; row <= rowCount; row++) {
            for(int col = 1; col <= colCount; col++) {
                if(matrix[row-1][col-1] == '1') {
                    // check adjacent and see if they form a square
                    int left = dp[row, col-1];
                    int top = dp[row-1, col];

                    int diagonal = dp[row-1, col-1];
                    
                    // Math.Min(Math.Min(left, top), diagonal);
                    dp[row, col] = FindMin(new int[]{top,left,diagonal}) + 1; 
                    
                    maxSqlLenSoFar = Math.Max(maxSqlLenSoFar, dp[row, col]);
                }
            }
        }
        return maxSqlLenSoFar * maxSqlLenSoFar;
    }
    
    private int FindMin(int[] values) {
        int ans = int.MaxValue;
        
        foreach(int num in values){
            if(num < ans) {
                ans = num;
            }
        }
        
        return ans;
    }
}