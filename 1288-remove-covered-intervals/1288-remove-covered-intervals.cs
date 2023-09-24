public class Solution {
    public int RemoveCoveredIntervals(int[][] intervals) {
        int res = 0, right = 0;
        Array.Sort(intervals, (a, b) => a[0] != b[0] ? a[0] - b[0] : b[1] - a[1]);
        foreach (int[] v in intervals) {
            if (v[1] > right) {
                ++res;
                right = v[1];
            }
        }
        return res;
    }
}