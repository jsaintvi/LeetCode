public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        
        int rowCount = obstacleGrid.Length;
        int colCount = obstacleGrid[0].Length;
        
        // if first cell has an obstacle, there is no path to destination
        if(obstacleGrid[0][0] == 1){
            return 0;
        }
        
        // number of ways of reaching starting cell
        obstacleGrid[0][0] = 1;
        
        // filling the values for the first column
        for(int i = 1; i < rowCount; i++)
            obstacleGrid[i][0] = (obstacleGrid[i][0] == 0 && obstacleGrid[i - 1][0] == 1) ? 1 : 0;
        
        // filling the values for the first row
        for(int i = 1; i < colCount; i++)
            obstacleGrid[0][i] = (obstacleGrid[0][i] == 0 && obstacleGrid[0][i - 1] == 1) ? 1 : 0;
        

        for(int i = 1; i < rowCount; i++) {
            for(int j = 1; j < colCount; j++) {
                if(obstacleGrid[i][j] == 1) { //obstacle, do not include
                    obstacleGrid[i][j] = 0;
                }else{
                    // number of ways of reaching this cell is : number of ways of reaching the cell to its left and number of ways of reaching the cell above it
                    obstacleGrid[i][j] = obstacleGrid[i - 1][j] + obstacleGrid[i][j - 1];
                }
            }
        }
        
        return obstacleGrid[rowCount - 1][colCount - 1];
    }
}