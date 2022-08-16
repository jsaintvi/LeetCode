public class Solution {
    public int HeightChecker(int[] heights) {
        int n = heights.Length;
        
        int[]  expected = new int[n];
        Array.Copy(heights, expected, n);
        
        Array.Sort(expected);
        
        int mismatchCount = 0;
        for(int i = 0; i < n; i++) {
            if(heights[i] != expected[i])
                mismatchCount++;
        }
        return mismatchCount;
    }
    
}