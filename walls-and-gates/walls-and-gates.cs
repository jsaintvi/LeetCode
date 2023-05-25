public class Solution {
    public const int GATE = 0;
    public const int EMPTY = int.MaxValue;
    public void WallsAndGates(int[][] rooms) {
        int rowCount = rooms.Length;

        if(rowCount == 0) return;

        int colCount = rooms[0].Length;

        var q = new Queue<int[]>();

        for(int row = 0; row < rowCount; row++) {
            for(int col = 0; col < colCount; col++) {
                if(rooms[row][col] == GATE) {
                    q.Enqueue(new int[] {row,col});
                }
            }
        }

        List<int[]> directions = new() {
            new int[] {1,0},
            new int[] {-1, 0},
            new int[] {0, 1},
            new int[] {0, -1}
        };

        while(q.Count > 0) {
            int[] point = (int[])q.Dequeue();
            int row = point[0];
            int col = point[1];


            foreach(int[] direction in directions) {
                int newRow = row + direction[0];
                int newCol = col + direction[1];

                // check if out of bounds OR invalid placement
                if(
                    newRow < 0 || newRow >= rowCount 
                    || newCol < 0 || newCol >= colCount 
                    || rooms[newRow][newCol] != EMPTY
                ) {
                    continue;
                }

                rooms[newRow][newCol] = rooms[row][col] + 1;
                q.Enqueue(new int[] {newRow, newCol});
            }
        }
    }
}