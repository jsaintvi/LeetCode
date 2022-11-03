public class Solution {
    public int NumDecodings(string s) {
        Dictionary<int,int> memo = new();
        return Dp(s, 0, memo);
    }
    
    private int Dp(string s, int currIdx, Dictionary<int,int> memo) {
        if(memo.ContainsKey(currIdx))
            return memo[currIdx];
        
        // reach end of string
        if(currIdx == s.Length) {
            return 1;
        }
        
        if(s[currIdx] == '0') { // unable to decode if starts with 0
            return 0;
        }
        
        if(currIdx == s.Length - 1) {
            return 1;
        }
        
        int ans = Dp(s, currIdx+1, memo); // consider decoding using one digit
        
        int currNum = int.Parse(s.Substring(currIdx, 2)); // looking at 2 digits
        
        if(currNum <= 26) {
            ans += Dp(s, currIdx+2, memo); // consider decoding using one digit
        }
        
        memo.Add(currIdx, ans);
        return ans;
    }
}