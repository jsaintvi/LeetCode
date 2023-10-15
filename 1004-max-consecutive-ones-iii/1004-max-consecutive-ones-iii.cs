public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int n = nums.Length;
        
        int l = 0, r = 0;
        
        int maxOnes = 0;
        int zeroCount = 0;
        while(r < n) {
            if(nums[r] == 0) {
                zeroCount += 1;
            }
            
            if(zeroCount > k) {

                if(nums[l] == 0)
                    zeroCount -= 1;

                l+= 1;
            }
            
            maxOnes = Math.Max(maxOnes, r - l + 1);
            
            r++;
        }
        
        return maxOnes;
    }
}