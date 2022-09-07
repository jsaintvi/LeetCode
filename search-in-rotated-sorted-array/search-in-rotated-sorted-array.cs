public class Solution {
    public int Search(int[] nums, int target) {
    
        return Search(nums, 0, nums.Length - 1, target);
        
    }
    
    
    private int Search(int[] nums, int low, int high, int key)
    {
        if (low > high)
        {
            return -1;
        }

        int mid = (low + high) / 2;

        if (nums[mid] == key)
            return mid;
        

        if (key == nums[low])
            return low;
        if (key == nums[high])
            return high;

        // array[low...mid] is sorted
        if (nums[low] < nums[mid])
        {
            if (key > nums[low] && key < nums[mid])
            {
                return Search(nums, low, mid - 1, key);
            }

            return Search(nums, mid + 1, high, key);
        }

        // array[mid...high] must be sorted then
        if (key >= nums[mid] && key <= nums[high])
        {
            return Search(nums, mid + 1, high, key);
        }

        return Search(nums, low, mid - 1, key);
    }
    
    
}