public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int n = nums.Length;
        
        int[] result = new int[2]{-1, -1};
        if(n == 0) 
            return result;
        
        int first = First(nums, target);
        int last = Last(nums, target);
        
        
        return new int[]{first, last};
    }
    
    private int First(int[] nums, int target) {
        int low = 0;
        int high = nums.Length -1;
        int res = -1;
        while(low <= high) {
            int mid = low +(high - low)/2;
            
            if(target < nums[mid]) {
                high = mid -1;
            } else if(target > nums[mid]) {
                low = mid + 1;
            } else { // match target
                res = mid;
                high = mid - 1;
            }
        }
        
        return res;
    }
    
    private int Last(int[] nums, int target) {
        int low = 0;
        int high = nums.Length -1;
        int res = -1;
        while(low <= high) {
            int mid = low + (high - low)/2;
            
            if(target < nums[mid]) {
                high = mid -1;
            } else if(target > nums[mid]) {
                low = mid + 1;
            } else { // match target
                res = mid;
                low = mid + 1;
            }
        }
        
        return res;
    }
}