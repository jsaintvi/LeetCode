public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) {
     
        int ans = 0;
        foreach(int hour in hours)
        {
            if(hour >= target)
                ans++;
        }
        return ans;
    }
}