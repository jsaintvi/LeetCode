public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int n = nums.Length;
        double sum = 0;
        for(int i = 0; i < k; i++)
            sum+= nums[i];
        
        double res = sum;
        for(int i = k; i < n; i++) {
            sum += nums[i] - nums[i-k];
            
            res = Math.Max(res, sum);
        }
        
        return res/k;
    }
}