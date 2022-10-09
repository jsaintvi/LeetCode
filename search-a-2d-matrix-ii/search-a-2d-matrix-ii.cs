public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int row = 0;
        int col = matrix[0].Length - 1;
        // start at top right corner
        // if target < currentElem at pos[i][j] move left(j--) else move down (i++) 
        while(row < matrix.Length && row >= 0 && col >= 0 && col < matrix[0].Length) {
            if(target == matrix[row][col]) return true;
            
            if(target < matrix[row][col]) {
                col--;
            } else {
                row++;
            }
        }
        
        return false;
    }
}