public class Solution {
    public int MaximumNumberOfStringPairs(string[] words) {
        Dictionary<string, List<string>> map = new();
        
        foreach(var word in words) {
            var wordChars = word.ToCharArray();
            Array.Sort(wordChars);
            
            var sortedWord = new String(wordChars);
            if(!map.ContainsKey(sortedWord))
                map.Add(sortedWord, new List<string>());
            
            map[sortedWord].Add(word);
        }
        
        int count = 0;
        foreach(var kv in map)
        {
            if(kv.Value.Count() == 2)
            {
                count++;
            }
        }
        
        return count;
    }
}