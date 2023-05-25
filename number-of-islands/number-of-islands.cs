public class Solution {
    public int NumIslands(char[][] grid) {
        int count=0;
        for(int i =0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[0].Length; j++)
            {
                if(grid[i][j] == '1')
                {
                    count++;
                    DFS(grid, i, j);
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