public class Solution {
    public int NumDecodings(string s) {
        if(string.IsNullOrEmpty(s)) 
            return 0;
        
        
        int n = s.Length;
        int[] dp = new int[n+1]; // num ways to decode for substring of s from index 0 to index index - 1
        dp[0] = 1; 
        
        // if first char is 0 (invalid) then no decode is possible else 1 way
        dp[1] = s[0] == '0' ? 0 : 1;
        
        for(int i = 2; i < dp.Length; i++) {
            // check if can decode using 1 digit1
            if(s[i-1] != '0') {
                dp[i] = dp[i-1];
            }
            
            // check if can decode using 2 digits
            int two_digit = int.Parse(s.Substring(i-2, 2));
            if(two_digit >= 10 && two_digit <= 26) {
                dp[i] += dp[i-2];
            }
            
        }
        
        return dp[n];
    }
}