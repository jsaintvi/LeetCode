public class Solution {
    public int FindNonMinOrMax(int[] nums) {
     if (nums.Length < 3) return -1;

        var (a, b, c) = (nums[0], nums[1], nums[2]);
        var min = Math.Min(Math.Min(a, b), c);
        var max = Math.Max(Math.Max(a, b), c);

        if (a != min && a != max) return a;
        if (b != min && b != max) return b;
        return c;
    }
}