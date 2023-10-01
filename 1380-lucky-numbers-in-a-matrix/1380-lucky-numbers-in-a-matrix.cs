public class Solution {
    public IList<int> LuckyNumbers (int[][] matrix) {
        int rows = matrix.Length, cols = matrix[0].Length;
        
        List<int> nums = new();
        
        for(int row = 0; row < rows; row++)
        {
            int smallestNumInRow = int.MaxValue;
            int smallestNumColIdx = -1;
            // find smallest number in row
            for(int col = 0; col < cols; col++) {
                if(matrix[row][col] < smallestNumInRow) {
                    smallestNumInRow = matrix[row][col];
                    smallestNumColIdx = col;   
                }
            }
            
            bool shouldAdd = true;
            for(int i = 0; i < rows; i++) {
                if(matrix[i][smallestNumColIdx] > smallestNumInRow ) {
                    shouldAdd = false;
                }
            }
            
            if(shouldAdd) nums.Add(smallestNumInRow);
        }
        
        return nums;

    }
}