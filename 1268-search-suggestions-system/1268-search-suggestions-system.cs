public class Solution {    
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        Trie trie = new Trie();
        foreach (string product in products.OrderBy(p => p))
            trie.Insert(product);

        List<IList<string>> result = new List<IList<string>>();
        string prefix = "";
        foreach (char c in searchWord)
        {
            prefix += c;
            result.Add(trie.GetSuggestions(prefix));
        }
        return result;
    }
}

public class TrieNode
{
    public Dictionary<char, TrieNode> Children { get; }
    public List<string> Suggestions { get; }

    public TrieNode()
    {
        Children = new Dictionary<char, TrieNode>();
        Suggestions = new List<string>();
    }
}

public class Trie
{
    private TrieNode root;

    public Trie()
    {
        root = new TrieNode();
    }

    public void Insert(string word)
    {
        TrieNode current = root;
        foreach (char c in word)
        {
            if (!current.Children.ContainsKey(c))
                current.Children[c] = new TrieNode();
            
            current = current.Children[c];
            
            // Add the word to the suggestions list of the current node
            // This helps in retrieving suggestions efficiently
            current.Suggestions.Add(word);
        }
    }

    public List<string> GetSuggestions(string prefix)
    {
        TrieNode current = root;
        foreach (char c in prefix)
        {
            if (!current.Children.ContainsKey(c))
                return Enumerable.Empty<string>().ToList();
            
            current = current.Children[c];
        }
        
        // Return the first three suggestions (if available)
        return current.Suggestions.Take(3).ToList();
    }
}