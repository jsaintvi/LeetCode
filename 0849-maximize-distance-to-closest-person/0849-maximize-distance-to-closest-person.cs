public class Solution {
    public int MaxDistToClosest(int[] seats) {
        int res = 0, n = seats.Length, last = -1;
        for (int i = 0; i < n; ++i) {
            if (seats[i] == 1) {
                res = last < 0 ? i : Math.Max(res, (i - last) / 2);
                last = i;
            }
        }
        res = Math.Max(res, n - last - 1);
        return res;
    }
}