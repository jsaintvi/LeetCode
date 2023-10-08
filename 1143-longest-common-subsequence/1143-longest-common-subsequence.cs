public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int m = text1.Length;
        int n = text2.Length;
        int[,] lcs = new int[2, n+1];
        
        // initialize first row and first column to 0 (base case)
        for(int row = 0; row <= 1; row++) {
            lcs[row, 0] = 0;
        }
        
        for(int col = 0; col <= n; col++) {
            lcs[0, col] = 0;
        }
        
        for(int i = 1; i <= m; i++) {
            for(int j = 1; j <= n; j++) {
                if(text1[i-1].Equals(text2[j-1]))
                {
                    lcs[i%2,j] = 1 + lcs[(i-1) % 2, j-1];
                } else { // chars not equal
                    lcs[i%2,j] = Math.Max(lcs[(i-1) % 2, j], lcs[i % 2, j-1]);
                }
            }
        }
        
        return lcs[m%2, n];
    }
}