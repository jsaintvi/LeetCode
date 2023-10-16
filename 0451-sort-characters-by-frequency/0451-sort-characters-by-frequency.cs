public class Solution {
    public string FrequencySort(string s) {

        Dictionary<char, UniqueChar> freqMap = new();
        
        int n = s.Length;
        for(int i = 0; i < n; i++) {
            char c = s[i];
            if(!freqMap.ContainsKey(s[i])) {
                
                freqMap.Add(c, new UniqueChar() {Char = c, FreqCount = 1, FirstIndex = i});
            } else {
                freqMap[c].FreqCount += 1;
            }
        }
        
        List<UniqueChar> chars = freqMap.Values.ToList();
        

        
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