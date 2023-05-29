public class Solution {
    public int NumIslands(char[][] grid) {
        int count=0;
        for(int row =0; row < grid.Length; row++)
        {
            for(int col = 0; col < grid[0].Length; col++)
            {
                if(grid[row][col] == '1')
                {
                    count++;
                    DFS(grid, row, col);
                }
            }
        }
        
        return count;
    }
    
    private void DFS(char[][] grid, int row, int col)
    {
        // if out of bounds, skip
        if(row < 0 || row >= grid.Length || col < 0 || col >= grid[row].Length) return;
        // if  already visited, skip
        if(grid[row][col] == '0') return;
        
        // mark as visited
        grid[row][col] = '0';
        
        // visit adjacent nodes
        DFS(grid, row + 1, col); // up
        DFS(grid, row-1, col); // down
        DFS(grid, row, col-1); // left;
        DFS(grid, row, col+1);// right;
    }
}