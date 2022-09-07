public class Solution {
    public int Search(int[] nums, int target) {
    
        int low = 0;
        int high = nums.Length -1;
        
        while(low <= high) {
            int mid = low + (high - low)/2;
            
            if(nums[mid] == target)
                return mid;
            
            if(nums[low] == target)
                return low;
            
            if(nums[high] == target)
                return high;
            
            // array[low...mid] is sorted
            if (nums[low] < nums[mid])
            {
                if (target > nums[low] && target < nums[mid])
                {
                    high = mid-1;
                }else{
                    low = mid + 1;
                }
            }else{
                // array[mid...high] must be sorted then
                if (target >= nums[mid] && target <= nums[high])
                {
                    low = mid + 1;
                }else{
                    high = mid-1;
                }
            }
        }
        
        return -1;
        
    }    
}