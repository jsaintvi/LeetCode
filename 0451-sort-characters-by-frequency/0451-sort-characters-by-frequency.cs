public class Solution {
    public string FrequencySort(string s) {

        Dictionary<char, int> freqMap = new();
        Dictionary<char, int> firstIndexMap = new();
        
        int n = s.Length;
        for(int i = 0; i < n; i++) {
            char c = s[i];
            if(!freqMap.ContainsKey(s[i])) {
                
                freqMap.Add(c, 1);
                firstIndexMap.Add(c, i);
            } else {
                freqMap[c] += 1;
            }
        }
        
        List<UniqueChar> chars = new();
        
        foreach(KeyValuePair<char,int> kv in freqMap) {
            var c = new UniqueChar() {
                Char = kv.Key,
                FreqCount = kv.Value,
                FirstIndex = firstIndexMap[kv.Key]
            };
            
            chars.Add(c);
        }
        
        chars.Sort((x,y) => {
            if(x.FreqCount != y.FreqCount) {
                return y.FreqCount - x.FreqCount;
            }
            
            return x.FirstIndex - y.FirstIndex;
        });
        
        StringBuilder sb = new();
        foreach(var c in chars) {
            for(int i = 0; i < c.FreqCount; i++) {
                sb.Append(c.Char);
            }
        }
        
        return sb.ToString();
        
    }
    
    private class UniqueChar{
        public char Char {get; set;}
        public int FreqCount {get;set;}
        public int FirstIndex {get;set;}
    }
}