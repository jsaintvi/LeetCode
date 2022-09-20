public class Solution {
        public int FindMin(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            if (nums[0] < nums[nums.Length - 1])
            {
                return nums[0];
            }
            return FindMin(nums, 0, nums.Length - 1);
        }

        private int FindMin(int[] nums, int low, int high)
        {
            // if one element left
            if (low == high)
            {
                return nums[low];
            }

            int mid = low + (high - low) / 2;
            
            if(nums[low]==nums[high])
                return Math.Min(FindMin(nums,low,mid), FindMin(nums,mid+1,high));
            
            if(nums[mid]>nums[high])
                return   FindMin(nums,mid+1,high);
            else
                return FindMin(nums,low,mid);

        }
}