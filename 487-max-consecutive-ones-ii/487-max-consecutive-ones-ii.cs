public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int left = 0;
        int right = 0;
        
        int numZerosSeen = 0;
        int longestSequence = 0;
        int n = nums.Length;
        
        while(right < n) {
            if(nums[right] == 0)
                numZerosSeen++;
            

            while(numZerosSeen ==2) { // INVALID state: contract window 
                if(nums[left] == 0){
                    numZerosSeen--;
                }
                left++;
            }
            
            longestSequence = Math.Max(longestSequence, right - left + 1);
            
            // expand window
            right++;
        }
        
        return longestSequence;
    }
}