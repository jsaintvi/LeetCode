public class Solution {
    public int FindNonMinOrMax(int[] nums) {
        int ans = -1;
        
        /*
            min = -1   1
            max = -1   4
            
            
        
        */
        
        if(nums.Length <= 2) return -1;
        
        
        int min = Math.Min(nums[0], nums[1]);
        
        int max = Math.Max(nums[0], nums[1]);
        
        for(int i = 2; i < nums.Length; i++) {
            int currNum = nums[i];
            // Console.WriteLine($"Curr Num: {currNum} - Min {min} - MAX {max}. Updated ans {ans}");

            // perform update
            if(currNum < min)
            {
                ans = min;

                min = currNum;
            }else if(currNum > max)
            {
                ans = max;

                max = currNum;
            } else{
                ans = currNum;
            }
            
            // Console.WriteLine($"UPDATED Curr Num: {currNum} - Min {min} - MAX {max}. Updated ans {ans}");
        }
        
        return ans;
    }
}