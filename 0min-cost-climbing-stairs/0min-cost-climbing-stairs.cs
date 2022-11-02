public class Solution {
    public int MinCostClimbingStairs(int[] cost) {

        int takeOneStep = 0;
        int takeTwoStep = 0;
        
        for(int i = 2; i < cost.Length + 1; i++) { // + 1 as we treat the 'top' floor as the final step
            int temp = takeOneStep;
            takeOneStep = Math.Min(takeOneStep + cost[i-1], takeTwoStep + cost[i-2]);
            takeTwoStep = temp;
        }
        
        return takeOneStep;
    }
}