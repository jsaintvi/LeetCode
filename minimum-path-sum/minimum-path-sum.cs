public class Solution {
    public int MinPathSum(int[][] grid) {
        int rows= grid.Length;
        int cols = grid[0].Length;
        int[,] dp = new int[rows, cols];
        
        for(int row = rows-1; row >= 0; row--) {
            for(int col = cols - 1; col >= 0; col--) {
                if(row == rows - 1 && col != cols-1) {
                    dp[row,col] = grid[row][col] + dp[row, col+1];
                } else if(col == cols - 1 && row != rows-1){
                    dp[row,col] = grid[row][col] + dp[row+1, col];
                } else if(col != cols-1 && row != rows - 1){
                    dp[row,col] = grid[row][col] + Math.Min(dp[row+1, col], dp[row, col+1]);
                }else{
                    dp[row,col] = grid[row][col];
                }
            }
        }
        
        return dp[0,0];
    }
}