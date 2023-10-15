public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {

        int n = nums.Length;
        
        int maxOnes = 0;
        int counter = 0;
        for(int i = 0; i < n; i++) {
            if(nums[i] == 0) {
                counter = 0; // reset
            } else{
                counter += 1;
                maxOnes = Math.Max(maxOnes, counter);
            }
        }
        
        return maxOnes;
    }
}