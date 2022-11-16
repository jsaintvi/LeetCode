public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        var memo = new Dictionary<string, int>();
        
        return Solve(obstacleGrid, 0, 0, memo);
    }
    
    private int Solve(int[][] grid, int row, int col, Dictionary<string, int> mem)
    {
        var key = $"{row}_{col}";
        if (mem.ContainsKey(key))
        {
            return mem[key];
        }
        
        // out of bounds or obstacles
        if (row >= grid.Length || col >= grid[row].Length || grid[row][col] == 1)
        {
            return 0;
        }

        if (row == grid.Length - 1 && col == grid[row].Length - 1)
        {
            return 1;
        }
        
        mem.Add(key, Solve(grid, row + 1, col, mem) + Solve(grid, row, col + 1, mem));
        
        return mem[key];
    }
}