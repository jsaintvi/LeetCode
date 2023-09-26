public class Solution {
    public IList<int> MinSubsequence(int[] nums) {
        int sum = nums.Sum();
        
        // sort by decreasing order
        Array.Sort(nums, (n1, n2) => n2.CompareTo(n1));
        int currSum = 0;

        IList<int> res = new List<int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if (sum < currSum) break;
            else res.Add(nums[i]);
            
            currSum += nums[i];
            sum -= nums[i];
        }

        return res;
    }
}