public class Solution {
    private class Point {
        public int X {get;set;}
        public int Y {get; set;}
        
        public Point(int x, int y) {
            this.X = x;
            this.Y = y;
        }
    }
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        
        if(image[sr][sc] == color)
        {
            return image;
        }
        
        int originalColor = image[sr][sc];
        int rowCount = image.Length;
        int colCount = image[0].Length;
        
        Queue<Point> q = new();
        q.Enqueue(new Point(sr, sc));
        
        while(q.Count > 0) {
            
            int row = q.Peek().X;
            int col = q.Peek().Y;
            q.Dequeue();
            
            // check for invalid i.e out of bounds cells
            if(row < 0 || row >= rowCount || col < 0 || col >= colCount) continue;
            if(image[row][col] == originalColor) {
                // paint with new color and push adjacents to stack
                image[row][col] = color;
                
                q.Enqueue(new Point(row + 1, col));
                q.Enqueue(new Point(row - 1, col));
                q.Enqueue(new Point(row, col - 1));
                q.Enqueue(new Point(row, col + 1));
            }
        }
        
        return image;
    }
}