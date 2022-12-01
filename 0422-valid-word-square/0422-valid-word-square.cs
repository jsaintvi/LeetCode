public class Solution {
    public bool ValidWordSquare(IList<string> words) {
        
        for(int row = 0; row < words.Count(); row++) {
            var currWord = words[row];
            
            for(int col = 0; col < currWord.Length; col++) {
                char c1 = currWord[col];
                /*
                 * Mismatch if:
                 * 1) words[j] does not exist i.e  j >= words.Length
                 * 2) words[j] may not have charAt(i)  ==>  i >= words[j].Length   
                 * 3) c2 exists but may not match c1       ==>  c2 != c1
                */
                if (col >= words.Count() || row >= words[col].Length) 
                    return false;
                
                char c2 = words[col][row];
                if (c1 != c2) return false;
            }
        }
        
        return true;
    }
}