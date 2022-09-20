public class Solution {
        public int[] Intersect(int[] nums1, int[] nums2) {
        
            if(nums1.Length==0 || nums2.Length ==0) return new List<int>().ToArray();
            
            Dictionary<int, int> map = new Dictionary<int, int>();

            List<int> ans = new List<int>();

            foreach (var s in nums1)
            {
                if(!map.ContainsKey(s)) map.Add(s,0);
                map[s]++;

            }
            
            foreach (var t in nums2)
            {
                if (map.ContainsKey(t) && map[t]> 0)
                {
                    ans.Add(t);
                    map[t]--;
                }
            }

            return ans.ToArray();
        }
}