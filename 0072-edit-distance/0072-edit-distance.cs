public class Solution {
    public int MinDistance(string word1, string word2) {
        int m = word1.Length;
        int n = word2.Length;
        return MinDistance(word1, word2, m, n, new Dictionary<string, int>());
    }
    
    private int MinDistance(string word1, string word2, int m, int n, Dictionary<string, int> map) {
        // TO transform 1 string into empty string, we delete all its chars. Same way, to transform an EMPTY string into non-empty string
        if(m == 0) { // empty
            return n;
        }
        
        if( n == 0) {
            return m;
        }
        
        var key = $"{m}-{n}";
        if(map.ContainsKey(key)) {
            return map[key];
        }
        
        //map.Add(key, -1);
        
        if(word1[m-1] == word2[n-1]) { // chars are equal
            map[key] =  MinDistance(word1, word2, m-1, n-1, map);
        } else {
            // --------------------------------------------------------------------
            //| We need to explore all 3 options: 
            //| 1 - INSERT: MinDIstance(word1, word2, m, n-1) 
            //| 2 - DELETE: MinDIstance(word1, word2, m - 1, n)  
            //| 3 - REPLACE: (MinDistance(word1, word2, m-1, n-1))
            //---------------------------------------------------------------------
            
            map[key] =  1 + Min(
                MinDistance(word1, word2, m, n-1, map),
                MinDistance(word1, word2, m - 1, n, map),
                MinDistance(word1, word2, m - 1, n-1, map)
            );
        }
        
        return map[key];
    }
    
    private int Min(params int[] vals) {
        int min = int.MaxValue;
        foreach(var val in vals){
            if(val < min) {
                min = val;
            }
        }
        
        return min;
    }
}