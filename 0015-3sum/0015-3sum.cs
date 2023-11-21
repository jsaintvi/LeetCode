public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> res = new List<IList<int>>();
        int n = nums.Length;
        if(n == 0) return res;
        Array.Sort(nums);
        
        for (int i = 0; i < n-2; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) continue; // skip duplicates from left
            int j = i + 1, k = n - 1;
            int target = -nums[i];
            
            while (j < k) {
                if (nums[j] + nums[k] == target) {
                    res.Add(new List<int>(){nums[i], nums[j], nums[k]});
                    j++; k--;
                    while (j < k && nums[j] == nums[j - 1]) j++; // skip duplicates from right
                    while (j < k && nums[k] == nums[k + 1]) k--; // skip duplicates from left
                }
                else if (nums[j] + nums[k] < target) j++;
                else k--;
            }
        }
        
        return res;
    }
}