public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int ans = 0;
        
        for(int i = 0; i < nums.Length; i++) {
            int numZeroes = 0;
            for(int j = i; j < nums.Length; j++ ) {
                if(nums[j] == 0)
                    numZeroes++;
                
                if(numZeroes <= 1){ // can flip at most 1 zero
                    ans = Math.Max(ans, j - i + 1);
                }
            }
        }
        
        return ans;
    }
}