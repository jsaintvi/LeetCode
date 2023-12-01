public class Solution {
    public int FindMin(int[] nums) {
        int len = nums.Length;
        
        int left = 0;
        int right = len - 1;
        
        while(left < right) {
            int mid = left + (right - left) /2;
            
            if(nums[mid] > nums[right]) {
                left = mid + 1;
            } else{
                right = mid;
            }
        }
        
        return nums[left];
    }
}