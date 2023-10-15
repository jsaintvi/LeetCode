public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int n = nums.Length;
        
        int l = 0;
        
        int maxOnes = 0;
        int zeroCount = 0;
        for(int r = 0; r < n; r++) {
            if(nums[r] == 0) {
                zeroCount += 1;
            }
            
            if(zeroCount > k) {

                if(nums[l] == 0)
                    zeroCount -= 1;

                l+= 1;
            }
            
            maxOnes = Math.Max(maxOnes, r - l + 1);
        }
        
        return maxOnes;
    }
}