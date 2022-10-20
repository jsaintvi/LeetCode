public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;        

        Dictionary<int,int> cache = new();
        
        return Dp(nums, n-1, cache);
        
    }
    
    private int Dp(int[] nums, int index, Dictionary<int,int> cache) {
        if(index == 0)
            return nums[0];
        if(index ==1)
            return Math.Max(nums[0], nums[1]);
        
        if(cache.ContainsKey(index))
            return cache[index];
        
        cache.Add(index, Math.Max( Dp(nums, index-1, cache),  Dp(nums, index-2, cache) + nums[index]));
        
        return cache[index];
    }
}