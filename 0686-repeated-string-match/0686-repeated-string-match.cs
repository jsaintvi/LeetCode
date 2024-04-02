public class Solution {
    public int RepeatedStringMatch(string a, string b) {
        int count = 1;
        StringBuilder repeated = new(a);
        
        while (repeated.Length < b.Length) {
            repeated.Append(a);
            count++;
        }
        
        if (repeated.ToString().Contains(b))
            return count;
        
        // One more repetition to cover all possibilities
        repeated.Append(a); 
        count++;
        
        if (repeated.ToString().Contains(b))
            return count;
        
        return -1;
    }
}