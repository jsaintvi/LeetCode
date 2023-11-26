public class Solution {
    public int[] CorpFlightBookings(int[][] bookings, int n) {
        int[] flightCapacity = new int[n+1];
        
        foreach(var booking in bookings)
        {
            var first = booking[0];
            var last = booking[1];
            var total = booking[2];
            
            for(int i = first; i <= last; i++)
                flightCapacity[i]+= total;
        }
        
        int[] ans = new int[n];
        int pos = 0;

        for(int i = 1; i < flightCapacity.Length; i++)
        {
            ans[i-1] = flightCapacity[i];
        }
        
        return ans;
        
    }
}