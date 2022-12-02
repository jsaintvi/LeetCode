public class Solution {
    public int MincostTickets(int[] days, int[] costs) {
        const int NUM_DAYS_IN_YEAR = 365; // maximum numbered day in your travel plan
        HashSet<int> daySet = new HashSet<int>(days);
        int[]memo = new int[NUM_DAYS_IN_YEAR + 1];
        
        for(int i = 0; i < memo.Length; i++) {
            memo[i] = int.MinValue;
        }
        
        return DP(1, daySet, costs, memo);
    }
    
    private int DP(int currDay, HashSet<int> days, int[]costs, int[]memo) {
        if(currDay > 365) // out of year bound
            return 0;
        
        if(memo[currDay] != int.MinValue)
            return memo[currDay];
        
        int ans;
        
        if(days.Contains(currDay)) {
            int buy1DayPass = DP(currDay+1, days, costs, memo) + costs[0];
            int buy7DayPass = DP(currDay+7, days, costs, memo) + costs[1];
            int buy30DayPass = DP(currDay+30, days, costs, memo) + costs[2];
            ans = FindMin(buy1DayPass, buy7DayPass, buy30DayPass);
        }else{ // not a traveling day - do nothing
            ans = DP(currDay + 1, days, costs, memo);
        }
        
        memo[currDay] = ans;
        
        return memo[currDay];
        
    }
    
    private int FindMin(params int[] values){
        int min = int.MaxValue;
        
        foreach(int val in values) {
            if(min > val) {
                min  = val;
            }
        }
        
        return min;
    }
}