public class Solution {
    public int StrStr(string haystack, string needle) {
        if(string.IsNullOrEmpty(haystack) && string.IsNullOrEmpty(needle))
            return 0;
        
        var index = haystack.IndexOf(needle);
        if(string.IsNullOrEmpty(haystack) || index == -1)
            return -1;
        
        return index;
    }
}