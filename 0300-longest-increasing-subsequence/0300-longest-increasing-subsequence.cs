public class Solution {
    public int LengthOfLIS(int[] nums) {
        int n = nums.Length;
        
        int[] dp = new int[n];
        
        Array.Fill(dp, 1);
        
        for(int i = 1; i < n; i++) {
            for(int j = 0; j < i; j++)
            {
                if(nums[i] > nums[j])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
        }
        
        int lis = 1;
        
        foreach(int val in dp)
            lis = Math.Max(lis, val);
        
        return lis;
    }
}