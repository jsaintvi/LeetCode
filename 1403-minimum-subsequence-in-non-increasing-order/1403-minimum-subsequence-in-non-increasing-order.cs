public class Solution {
    public IList<int> MinSubsequence(int[] nums) {
        int sum = nums.Sum();
        
        // sort by decreasing order
        Array.Sort(nums, (n1, n2) => n2.CompareTo(n1));
        int currSum = 0;

        IList<int> res = new List<int>();

        foreach (var num in nums)
        {
            currSum += num;
            res.Add(num);
            int diff = sum - currSum;

            if (currSum > diff)
            {
                break;
            }
        }

        return res;
    }
}