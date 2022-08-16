public class Solution {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            int n = nums.Length;
            if(n <=0) return new List<int>();
            HashSet<int> seen = new ();

            for (int i = 0; i < n; i++)
            {
                seen.Add(nums[i]);
            }
            
            IList<int> ans = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                if (!seen.Contains(i))
                {
                    ans.Add(i);
                }
            }

            return ans;
        }
}