public class Solution {
    public IList<string> FindWords(char[][] board, string[] words) {
        TrieNode root = new TrieNode();
        foreach (string word in words) {
            AddWord(root, word);
        }

        HashSet<string> resultSet = new HashSet<string>();
        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[0].Length; j++) {
                DFS(board, i, j, root, resultSet);
            }
        }

        return resultSet.ToList();
    }

    private void AddWord(TrieNode root, string word) {
        TrieNode node = root;
        foreach (char c in word) {
            if (!node.Children.ContainsKey(c)) {
                node.Children[c] = new TrieNode();
                node.Children[c].Word = node.Word + c;
            }
            node = node.Children[c];
        }
        node.IsEndOfWord = true;
    }

    private void DFS(char[][] board, int i, int j, TrieNode node, HashSet<string> resultSet) {
        char letter = board[i][j];
        if (letter == '#' || !node.Children.ContainsKey(letter)) return;

        node = node.Children[letter];
        if (node.IsEndOfWord) {
            resultSet.Add(node.Word);
        }

        board[i][j] = '#';
        int[] dx = {-1, 0, 1, 0};
        int[] dy = {0, 1, 0, -1};

        for (int k = 0; k < 4; k++) {
            int x = i + dx[k];
            int y = j + dy[k];
            if (x >= 0 && x < board.Length && y >= 0 && y < board[0].Length) {
                DFS(board, x, y, node, resultSet);
            }
        }

        board[i][j] = letter;
    }
}

public class TrieNode {
    public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
    public bool IsEndOfWord = false;
    public string Word = "";
}