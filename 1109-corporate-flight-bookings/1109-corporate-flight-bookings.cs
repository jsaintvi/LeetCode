public class Solution {
    public int[] CorpFlightBookings(int[][] bookings, int n) {
        var answer = new int[n];
        
        foreach (int[] booking in bookings) {
            int first = booking[0];
            int last = booking[1];
            int seats = booking[2];
            
            answer[first - 1] += seats; // minus cause flights are 1-based index
            if (last < n) {
                answer[last] -= seats;
            }
        }
        
        for (int i = 1; i < n; i++) {
            answer[i] += answer[i - 1];
        }
        
        return answer;
        
    }
}