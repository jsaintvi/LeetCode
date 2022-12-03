public class Solution {
    public string ArrangeWords(string text) {
        string[] words = text.Split(' ');
        var wordMap = BuildWordMap(words);
        
        var @keys = wordMap.Keys.ToList();
        
        keys.Sort();
        
        StringBuilder sb = new();
        foreach(var k in @keys) {
            var values = wordMap[k];
            for(int i = 0; i < values.Count; i++) {
                var currVal = values[i];
                
                if(sb.Length == 0) {
                    sb.Append(string.Concat(currVal[0].ToString().ToUpper(), currVal.AsSpan(1)));
                }else{
                    sb.Append(currVal.ToLower());
                }
                
                sb.Append(' ');

            }
        }
        
        return sb.ToString().TrimEnd(' ');
    }
    
    private Dictionary<int, List<string>> BuildWordMap(string[] words) {
        Dictionary<int, List<string>> map = new Dictionary<int, List<string>>();

        foreach(string word in words) {
            int wordLen = word.Length;

            if(!map.ContainsKey(wordLen)) map.Add(wordLen, new List<string>());

            map[wordLen].Add(word);
        }

        return map;
    }
}