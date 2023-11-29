public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int n = nums.Length;
        int left = 0;
        int right = 0;
        
        int sum = 0;
        
        int minLen = int.MaxValue;
        while(right < n) {
            sum += nums[right];
            
            while(sum >= target) { //shorten window
                minLen = Math.Min(minLen, right - left + 1);
                
                // shorten window
                sum -= nums[left];
                
                left++;
            }
            
            right++;
        }
        
        return minLen == int.MaxValue ? 0 : minLen;
    }
}