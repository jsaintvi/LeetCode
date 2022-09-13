public class Solution {
        public int FindMin(int[] nums)
        {
            int len = nums.Length;
            
            if (len == 1)
                return nums[0];

            if (nums[0] < nums[len - 1]) // no rotation
            {
                return nums[0];
            }
            
            int low = 0;
            int high = len - 1;
            
            while(low <= high) {
                int mid = low + (high - low)/2;
                
                // check if mid is the min elem
                if(mid > low && nums[mid] < nums[mid-1])
                {
                    return nums[mid];
                }
                
                // check if mid+1 is the min elem
                if(mid < high && nums[mid] > nums[mid+1]){
                    return nums[mid+1];
                }
                
                if(nums[low] > nums[mid]){
                    high = mid-1;
                }else{
                    low = mid+1;
                }
            }
            
            return -1;
        }
}