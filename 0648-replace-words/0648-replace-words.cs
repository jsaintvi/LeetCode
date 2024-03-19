public class Solution {
    public class TrieNode
    {
        public TrieNode[] Children {get;}
        public bool IsEndOfWord {get;set;}
        
        public TrieNode()
        {
            Children = new TrieNode[26];
            IsEndOfWord = false;
        }
    }
    public class Trie
    {
        TrieNode root;
        
        public Trie()
        {
            root = new TrieNode();
        }
        
        public void Insert(string word)
        {
            TrieNode curr = root;
            
            foreach(var c in word)
            {
                int index = c - 'a';
                if(curr.Children[index] == null)
                {
                    curr.Children[index] = new TrieNode();
                }
                
                curr = curr.Children[index];
            }
            
            curr.IsEndOfWord = true;
        }
        
        // get the shortest root of a word that exists in the Trie
        public string GetRoot(string word)
        {
            TrieNode curr = root;
            
            StringBuilder sb = new();
            foreach(var c in word)
            {
                int index = c - 'a';
                
                if(curr.Children[index] == null) 
                {
                    break;
                }
                
                sb.Append(c);
                curr = curr.Children[index];
                
                if(curr.IsEndOfWord)
                    return sb.ToString();
            }
            
            return null;
        }
    }
    public string ReplaceWords(IList<string> dictionary, string sentence) {
        Trie trie = new Trie();
        
        foreach(var word in dictionary)
        {
            trie.Insert(word);
        }
        
        string[] words = sentence.Split(" ");
        
        StringBuilder result = new();
        foreach(var word in words)
        {
            var match = trie.GetRoot(word) ?? word;
            result.Append(match).Append(' ');
        }
        
        return result.ToString().Trim();
    }
}