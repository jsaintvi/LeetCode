public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int>seen = new();
        
        foreach(var x in nums1)
        {
            seen.Add(x);
        }
        
        List<int> ans = new();
        foreach(var x in nums2){
            if(!seen.Contains(x) || ans.Contains(x)) continue;
            
            ans.Add(x);
        }
        
        return ans.ToArray();
    }
}