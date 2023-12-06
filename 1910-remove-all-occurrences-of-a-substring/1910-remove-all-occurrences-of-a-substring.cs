public class Solution {
    public string RemoveOccurrences(string s, string part) {
        
        int partLength = part.Length;

        while (s.Contains(part))
        {
            int index = s.IndexOf(part);
            s = s.Remove(index, partLength);
        }

        return s;
    }
}