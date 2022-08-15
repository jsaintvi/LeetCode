public class Solution {
    public void MoveZeroes(int[] nums) {
    
        int len = nums.Length;
        
        int lastNonZeroIndex = 0;
        
        for(int curr = 0; curr < len; curr++)
        {
            if(nums[curr] != 0)
            {
                Swap(nums, lastNonZeroIndex, curr);
                lastNonZeroIndex++;
            }
        }
    }
    
    private void Swap(int[] nums, int x, int y)
    {
        int temp = nums[x];
        
        nums[x] =nums[y];
        nums[y]= temp;
    }
}