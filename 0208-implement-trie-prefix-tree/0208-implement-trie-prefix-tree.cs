public class Trie {
    private class TrieNode {
        public char Key {get;set;}
        public bool IsEndOfWord {get;set;}
        public Dictionary<char, TrieNode> Children {get;set;}
        
        public TrieNode(char key) {
            this.Key = key;
            this.Children = new();
            this.IsEndOfWord = false;
        }
    }
    
    private TrieNode root;
    public Trie() {
        root = new TrieNode('\0');
    }
    
    public void Insert(string word) {
        if(string.IsNullOrEmpty(word))
            return;
        
        TrieNode currNode = root;
        foreach(var c in word) {
            if(!currNode.Children.ContainsKey(c))
            {
                currNode.Children[c] = new TrieNode(c);
            }
            
            currNode = currNode.Children[c];
        }
        
        currNode.IsEndOfWord = true;
    }
    
    public bool Search(string word) {
        if(string.IsNullOrEmpty(word))
            return false;
        
        TrieNode currNode = root;
        foreach(var c in word) {
            if(!currNode.Children.ContainsKey(c))
            {
                return false;
            }
            
            currNode = currNode.Children[c];
        }
        
        return currNode.IsEndOfWord;
    }
    
    public bool StartsWith(string prefix) {
        if(string.IsNullOrEmpty(prefix))
            return false;
        
        TrieNode currNode = root;
        foreach(var c in prefix) {
            if(!currNode.Children.ContainsKey(c))
            {
                return false;
            }
            
            currNode = currNode.Children[c];
        }
        
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */