public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int l = 0; 
        
        int n = nums.Length;
        
        int maxOnes = 0;
        while(l < n) {
           if(nums[l] == 0) {
               
               l += 1;
               
           } else{
               int r = l;
                while(r+1 < n && nums[r+1] == 1) {
                    r+=1;
                }
               
               maxOnes = Math.Max(maxOnes, r - l + 1);
                l = r+1;
           }
            
        }
        
        return maxOnes;
    }
}