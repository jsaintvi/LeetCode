public class Solution {
    public int[] RowAndMaximumOnes(int[][] mat) {
        int max = -1;
        int rowIndex = -1;

        for(int i = 0; i < mat.Length; i++) {
            int count = 0;
            for(int j = 0; j < mat[i].Length; j++) {
                if(mat[i][j] == 1) count++;
            }
            
            if(count > max) {
                max = count;
                rowIndex = i;
            }
        }

        return new int[]{rowIndex, max};
    }
}