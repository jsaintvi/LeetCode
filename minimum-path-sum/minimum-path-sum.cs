public class Solution {
    public int MinPathSum(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        
        
        var memo = new int[m,n];
        Fill(memo, -1);
        
        return Helper(grid, m - 1, n - 1, memo);
    }
    

    public int Helper(int[][] grid, int i, int j, int[,]memo) 
    {
        if(i < 0 || j < 0) return int.MaxValue;
        
        if(i== 0 && j == 0) { // first cell
            memo[i,j] = grid[0][0];    
            return memo[i,j];
        }
        
        if(memo[i,j] != -1) return memo[i,j];
        
        // deciding whether to go right or down (in reverse in our case)
        int takeDown =  Helper(grid, i-1, j, memo);
        int takeRight = Helper(grid, i, j-1, memo);
        
        
        Console.WriteLine($"To get to [{i}][{j}], we can go down with cost of {takeDown} or right with cost of {takeRight} added to currValue of {grid[i][j]}");
        memo[i,j] = grid[i][j] + Math.Min(takeDown, takeRight); 
        
        return memo[i,j];
    }
    
    private void Fill(int[,] memo, int val){
        
        int m = memo.GetLength(0);
        int n = memo.GetLength(1);
        for(int i = 0; i < m; i++)
            for(int j = 0; j < n; j++)
                memo[i,j] = val;
    }
}