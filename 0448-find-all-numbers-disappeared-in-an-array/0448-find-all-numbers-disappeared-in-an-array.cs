public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        var result = new List<int>();
        var set = new HashSet<int>(nums);

        for (int i = 1; i <= nums.Length; i++) {
            if (!set.Contains(i)) {
                result.Add(i);
            }
        }

        return result;
    }
}