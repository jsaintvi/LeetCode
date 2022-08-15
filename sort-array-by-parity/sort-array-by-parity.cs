public class Solution {
    public int[] SortArrayByParity(int[] nums) {
           
        int len = nums.Length;
        
        int lastEvenIndex = 0;
        
        for(int curr = 0; curr < len; curr++)
        {
            if(nums[curr] %2 == 0)
            {
                Swap(nums, lastEvenIndex, curr);
                lastEvenIndex++;
            }
        } 
        
        return nums;
    }
    
    
    private void Swap(int[] nums, int x, int y)
    {
        int temp = nums[x];
        
        nums[x] =nums[y];
        nums[y]= temp;
    }
}