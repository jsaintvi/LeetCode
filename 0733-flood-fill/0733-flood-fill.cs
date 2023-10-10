public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if(image[sr][sc] != color) {
            FloodFillHelper(image, sr, sc, image[sr][sc], color);
        }
        
        return image;
    }
    
    private void FloodFillHelper(int[][] image, int row, int col, int originalColor, int newColor) {
        int rowCount = image.Length;
        int colCount = image[0].Length;
        
        if(row < 0 || row >= rowCount || col < 0 || col >= colCount)
            return;
        
        if(image[row][col] == originalColor) {
            image[row][col] = newColor;
                    
            FloodFillHelper(image, row - 1, col, originalColor, newColor);// up
            FloodFillHelper(image, row + 1, col, originalColor, newColor);// down
            FloodFillHelper(image, row , col - 1, originalColor, newColor);// left
            FloodFillHelper(image, row , col + 1, originalColor, newColor);// right
        }

    }
}