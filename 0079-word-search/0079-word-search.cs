public class Solution {
    public bool Exist(char[][] board, string word) {
        int rowCount = board.Length;
        int colCount = board[0].Length;
        
        bool[,] visited = new bool[rowCount, colCount];
        
        for(int row = 0; row < rowCount; row++) {
            for(int col = 0; col < colCount; col++) {
                // if search does not start with matching first word, useless to explore
                if(board[row][col] != word[0]) continue;
                
                if(DFS(board, word, 0, row, col, visited)) {
                    return true;
                }
            }
        }
        
        return false;
    }
    
    private bool DFS(char[][]board,string word, int index, int row, int col, bool[,] vis) {
        if(word.Length == index) {
            return true;
        }
        
        // check if out of bounds
        if(row < 0 || row >= board.Length || col < 0 || col >= board[0].Length || vis[row,col])
            return false;
        
        // check if char at current index does not match curr char at board[row][col]
        if(word[index] != board[row][col])
            return false;
        
        // mark curr cell as visited
        vis[row, col] = true;
        
        // check for char match in all for directions
        if(
            DFS(board, word, index + 1, row - 1, col, vis) ||
            DFS(board, word, index + 1, row + 1, col, vis) ||
            DFS(board, word, index + 1, row, col - 1, vis) ||
            DFS(board, word, index + 1, row, col + 1, vis)
        )
            return true;
        
        // batcktrack
        vis[row, col] = false;
        return false;
    } 
}