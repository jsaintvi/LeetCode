public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        
        
        int[] freq = new int[26];
        
        // intializing direct address table O(1)
        for(int i = 0; i < 26; i++)
            freq[i] = 0;
        
        for(int i = 0; i < s.Length; i++)
            freq[s[i] - 'a'] += 1;
        
        for(int i = 0; i < t.Length; i++)
            freq[t[i] - 'a'] -= 1;
        
        for(int i = 0; i < 26; i++) {
            if(freq[i] != 0)
                return false;
        }
        
        return true;
    }
}