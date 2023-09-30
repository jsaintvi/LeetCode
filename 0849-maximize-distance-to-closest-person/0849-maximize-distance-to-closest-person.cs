public class Solution {
    public int MaxDistToClosest(int[] seats) {
        int res = 0, n = seats.Length, prevPersonIndex  = -1;
        
        for (int i = 0; i < n; ++i) {
            if (seats[i] == 1) { // // If a person is sitting at position i
                
                // Case 1: The first person, so distance is i
                // Case 2: Calculate the distance to the nearest person on both sides
                res = prevPersonIndex  == -1 ? i : Math.Max(res, (i - prevPersonIndex ) / 2);
                prevPersonIndex  = i;
            }
        }
        
        // Check for the distance to the last seat
        res = Math.Max(res, n - prevPersonIndex  - 1);
        return res;
    }
}