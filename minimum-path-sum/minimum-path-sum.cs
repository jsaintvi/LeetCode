public class Solution {
    public int MinPathSum(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        
        //Console.WriteLine("POPULATING first column");
        for(int i = 1; i < m; ++i) {
            grid[i][0] += grid[i - 1][0];
           // Print(grid, i , 0);
        }
        
        //Console.WriteLine("POPULATING first row");
        for(int j = 1; j < n; ++j) {
            grid[0][j] += grid[0][j - 1];
        // Print(grid, 0, j);   
        }

        //Console.WriteLine("------------------------");
        for(int i = 1; i < m; ++i){
            for(int j = 1; j < n; ++j){
                grid[i][j] += Math.Min(grid[i-1][j], grid[i][j-1]);
                //Print(grid, 0, j);   

            }
        }
        return grid[m-1][n-1];
    }
    
    private void Print(int[][] grid) {
        for(int i = 0; i < grid.Length; i++) {
            for(int j = 0; j < grid[0].Length; j++) {
                Console.WriteLine($"Value at index[{i}][{j}] is {grid[i][j]}");
            }
        }
    }
    
    private void Print(int[][]grid, int i , int j){
        Console.WriteLine($"Value at index[{i}][{j}] is {grid[i][j]}");

    }
}