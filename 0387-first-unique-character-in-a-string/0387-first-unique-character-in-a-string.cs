public class Solution {
    private class CharInfo{
        public int Index {get;set;}
        public int Count {get;set;}
    }
    public int FirstUniqChar(string s) {
        Dictionary<char, CharInfo> map = new();
        for(int i = 0; i < s.Length; i++) {
            var c = s[i];
            if(!map.ContainsKey(c))
                map.Add(c, new CharInfo() {Index = i, Count = 0});
            
            map[c].Count += 1;
        }
        
        foreach(var kv in map)
        {
            var c = kv.Value;
            if(c.Count == 1)
                return c.Index;
        }
        return -1;
    }
}