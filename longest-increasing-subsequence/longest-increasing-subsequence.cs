public class Solution {
    public int LengthOfLIS(int[] nums) {
        int n = nums.Length;
        int[] dp = new int[n];
        for(int i = 0; i < dp.Length; i++) {
            dp[i] = 1;
        }
        
        int res = 1;
        for(int i = 1; i <  nums.Length; i++) {
            for(int j = 0; j < i; j++) {
                if(nums[i] > nums[j]) {
                    dp[i] = Math.Max(dp[i], dp[j]+1);
                }
            }
            
            res = Math.Max(res, dp[i]);
        }
        
        return res;
    }
}