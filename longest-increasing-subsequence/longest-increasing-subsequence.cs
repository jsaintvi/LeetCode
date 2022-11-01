public class Solution {
    public int LengthOfLIS(int[] nums) {
        int n = nums.Length;
        int[] dp = new int[n];
        
        // each elem is a subsequence of their own (length of 1 which is themselves)
        for(int i = 0; i < dp.Length; i++) {
            dp[i] = 1;
        }
        
        for(int i = 1; i <  nums.Length; i++) {
            for(int j = 0; j < i; j++) {
                if(nums[i] > nums[j]) {
                    dp[i] = Math.Max(dp[i], dp[j]+1);
                }
            }
        }
        
        int longest = 0;
        
        foreach(int val in dp) {
            longest = Math.Max(longest, val);
        }
        return longest;
    }
}