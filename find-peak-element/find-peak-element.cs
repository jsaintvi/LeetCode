public class Solution {
    public int FindPeakElement(int[] nums)
    {        
        int len = nums.Length;
        int low = 0;
        int high = len - 1;
        
        while(low <= high){
            int mid = low + (high - low)/2;
            
            // compare mid elem with its neighbors(if neighbors exists)
            if ((mid == 0 || nums[mid - 1] <= nums[mid]) && (mid == len - 1 || nums[mid + 1] <= nums[mid]))
            {
                return mid;
            }    
            
            if(mid > 0 && nums[mid-1] > nums[mid]) {
                high = mid -1;
            }else{
                low = mid+1;
            }
        
        }
        
        return -1;
    }
}