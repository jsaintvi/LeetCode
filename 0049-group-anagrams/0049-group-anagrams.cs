public class Solution {
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children { get; private set; }
        public bool IsEndOfWord { get; set; }
        public List<string> Anagrams { get; private set; }

        public TrieNode()
        {
            Children = new Dictionary<char, TrieNode>();
            IsEndOfWord = false;
            Anagrams = new List<string>();
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
            string sortedWord = SortWord(word);
            TrieNode current = root;
            foreach (char c in sortedWord)
            {
                if (!current.Children.ContainsKey(c))
                {
                    current.Children[c] = new TrieNode();
                }
                current = current.Children[c];
            }
            current.IsEndOfWord = true;
            current.Anagrams.Add(word);
        }

        public List<string> FindAnagrams(string word)
        {
            string sortedWord = SortWord(word);
            TrieNode node = FindNode(sortedWord);
            return node != null ? node.Anagrams : new List<string>();
        }

        private TrieNode FindNode(string sortedWord)
        {
            TrieNode current = root;
            foreach (char c in sortedWord)
            {
                if (!current.Children.ContainsKey(c))
                {
                    return null;
                }
                current = current.Children[c];
            }
            return current;
        }

        private string SortWord(string word)
        {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }
    }
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var anagramPairs = new List<IList<string>>();
        Trie trie = new Trie();

        // Insert words into Trie
        foreach (string word in strs)
        {
            trie.Insert(word);
        }

        // Find anagram pairs
        
        foreach (string word in strs)
        {
            List<string> anagrams = trie.FindAnagrams(word);        
            
            anagramPairs.Add(anagrams);
        }

        return anagramPairs.Distinct().ToList();
    }
}