public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int n = cost.Length;

        return Dp(n, cost, new Dictionary<int,int>());
    }
    
    private int Dp(int index, int[]cost, Dictionary<int,int> cache) {
        // base cases : to take stair 0 or stair 1 cost 0
        if(index <= 1)
            return 0;
        
        if(cache.ContainsKey(index))
            return cache[index];
        
        int takeOneStep = cost[index-1] + Dp(index-1, cost, cache);
        int takeTwoStep = cost[index-2] + Dp(index-2, cost, cache);

        cache.Add(index, Math.Min(takeOneStep, takeTwoStep));
        
        return cache[index];
        
    }
}