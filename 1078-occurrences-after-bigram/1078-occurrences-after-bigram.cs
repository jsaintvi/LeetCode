public class Solution {
    public string[] FindOcurrences(string text, string first, string second) {
     string[] words = text.Split(" ");
        List<String> ans = new();
        
        for (int i = 2; i < words.Length; i++) {
            if (first.Equals(words[i - 2]) && second.Equals(words[i - 1]))
                ans.Add(words[i]);
        }
        return ans.ToArray();
    }
}