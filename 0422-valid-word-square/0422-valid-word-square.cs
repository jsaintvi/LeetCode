public class Solution {
    public bool ValidWordSquare(IList<string> words) {
        
        int rowCount = words.Count;
        
        for(int r = 0; r < rowCount; r++)
        {
            for(int c = 0; c < words[r].Length; c++)
            {
                if(c >= rowCount || r >= words[c].Length || words[r][c] != words[c][r])
                {
                    return false;
                }
            }
        }
        
        return true;
    }
}