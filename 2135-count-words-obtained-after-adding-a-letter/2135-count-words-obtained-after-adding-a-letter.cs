public class Solution {
    public int WordCount(string[] startWords, string[] targetWords) {
        
        Trie t = new();
        foreach(string word in startWords)
        {
            t.AddWord(SortString(word));
        }
        
        int ans = 0;
        
        foreach(string w in targetWords)
        {
            
           // Console.WriteLine($"------------INQUIRY for word {w}-------------");


           int i = 0; int j = w.Length - 1;
            
            
            while(i <= j)
            {
                string lookupWord = w.Substring(0, i) + w.Substring(i+1);
                var sortedWord = SortString(lookupWord);

                //Console.WriteLine($"----------------Searching for WORD {sortedWord}-------------");
                if(t.Search(sortedWord))
                {
                    //Console.WriteLine($"----------------FOUND {sortedWord}");
                    ans += 1;
                    break;
                } //else Console.WriteLine("---------------NOT FOUND------------");
                
                i++;
            }
            
            //Console.WriteLine($"------------INQUIRY COMPLETED-------------");

        }
        
        
        return ans;
    }
    
    string SortString(string input)
    {
        char[] characters = input.ToArray();
        Array.Sort(characters);
        return new string(characters);
    }
    
    public class Trie
    {
        private readonly TrieNode _root = new TrieNode();

        public void AddWord(string word)
        {
            var node = _root;

            foreach (char c in word)
            {
                if (!node.Children.ContainsKey(c))
                    node.Children[c] = new TrieNode();

                node = node.Children[c];
            }

            node.IsWord = true;
        }

        public bool Search(string word)
        {
            var node = _root;

            foreach (char c in word)
            {
                if (!node.Children.ContainsKey(c))
                    return false;

                node = node.Children[c];
            }

            return node.IsWord;
        }
    }
    
    public class TrieNode
    {
        public bool IsWord { get; set; }
        public Dictionary<char, TrieNode> Children { get; } = new Dictionary<char, TrieNode>();
    }
}