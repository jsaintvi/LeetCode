public class Solution {
    public int[] RowAndMaximumOnes(int[][] mat) {
        int[] ans = new int[2] {-1,-1};
        
        for(int row = 0; row < mat.Length; row++) {
            int maxOnes = 0;
            
            for(int col = 0; col < mat[0].Length; col++) {
                if(mat[row][col] == 1)
                    maxOnes +=1;
            }
            
            if(ans[1] < maxOnes) {
                ans[0] = row;
                ans[1] = maxOnes;
            }
        }
        return ans;
    }
}