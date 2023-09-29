public class Solution {
    public int MinDeletionSize(string[] strs) {
        int result = 0;
        int rows = strs.Length;
        int cols = strs[0].Length;
        
        for(int col = 0; col < cols; col++) {
            for(int row = 1; row < rows; row++) {
                if(strs[row][col] < strs[row-1][col]){
                    ++result;
                    break;
                }
            }
        }
        
        return result;
    }
}