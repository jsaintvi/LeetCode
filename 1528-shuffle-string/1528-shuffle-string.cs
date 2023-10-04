public class Solution {
    public string RestoreString(string s, int[] indices) {
        StringBuilder sb = new();
        char[] str = new char[indices.Length];
        for(int i = 0; i < indices.Length; i++) {
            str[indices[i]] = s[i];
        }
        
        return new string(str);
        
    }
}