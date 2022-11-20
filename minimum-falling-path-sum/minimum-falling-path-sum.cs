public class Solution {
    public int MinFallingPathSum(int[][] matrix) {
        int retVal = int.MaxValue;
        
        int m = matrix.Length;
        int n = matrix[0].Length;
        int[,] memo = new int[m,n];
        
        Fill(memo, int.MinValue);
        
        // path begins at any cell in ***first row*** qnd ends at ***any cell in last row***
        for(int startCol = 0; startCol < n; startCol++){
            retVal = Math.Min(retVal, DFS(matrix, 0, startCol, memo));
        }
        
        return retVal;
    }
    
    public int DFS(int[][]matrix, int row, int col, int[,] memo)
    {
        // check if out of bounds
        if(col  < 0 || col >= matrix.Length) {
            return int.MaxValue;
        }
        
        // check if we have reached last row
        if(row == matrix.Length - 1) {
            return matrix[row][col];
        }
        
        // check if result in cache
        if(memo[row,col] != int.MinValue) {
            return memo[row,col];
        }
        
        /*
                |     *cell     |
           left |    middle     | right       
        
        */
        int left = DFS(matrix, row+1, col-1, memo);
        int middle = DFS(matrix, row+1, col, memo);
        int right = DFS(matrix, row+1, col+1, memo);
        
        memo[row,col] = matrix[row][col] + FindMinOf(new int[]{left, middle, right});
        
        return memo[row,col];
    }
    
    private int FindMinOf(int[] values){
        int res = int.MaxValue;
        
        foreach(int val in values){
            res = Math.Min(res, val);
        }
        
        return res;
    }
    
    private void Fill(int[,] memo, int val){
        int m = memo.GetLength(0);
        int n = memo.GetLength(1);
        
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++) {
                memo[i,j] = val;
            }
        }
    }
}