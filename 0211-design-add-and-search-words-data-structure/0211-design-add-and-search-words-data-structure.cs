public class WordDictionary {

    private class TrieNode {
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public string item = "";
    }

    private TrieNode root = new TrieNode();

    // Adds a word into the data structure.
    public void AddWord(string word) {
        TrieNode node = root;
        foreach (char c in word) {
            if (!node.children.ContainsKey(c)) {
                node.children[c] = new TrieNode();
            }
            node = node.children[c];
        }
        node.item = word;
    }

    // Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter.
    public bool Search(string word) {
        return search(root, word, 0);
    }

    private bool search(TrieNode node, string word, int index) {
        if (index == word.Length) {
            return !string.IsNullOrEmpty(node.item);
        }

        char c = word[index];
        if (c == '.') {
            foreach (var child in node.children) {
                if (search(child.Value, word, index + 1)) {
                    return true;
                }
            }
            return false;
        } else {
            if (!node.children.ContainsKey(c)) {
                return false;
            }
            return search(node.children[c], word, index + 1);
        }
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */