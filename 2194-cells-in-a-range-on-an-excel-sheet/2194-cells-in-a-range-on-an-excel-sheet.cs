public class Solution {
    public IList<string> CellsInRange(string s) {
        
        char c1 = s[0];
        char row1 = s[1];
        
        char c2 = s[3];
        Char row2 = s[4];
        List<string> ans = new();
        
        for(char c = c1; c <= c2; c++)
        {
            for(char row = row1; row <= row2; row++)
            {
                ans.Add($"{c}{row}");
            }
        }
        
        return ans;
    }
}