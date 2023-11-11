public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int>seen = new(nums1);
        HashSet<int> nums2Set =  new (nums2);
        
        foreach(var x in nums1)
        {
            seen.Add(x);
        }
        
        List<int> ans = new();
        foreach(var x in nums2Set){
            if(!seen.Contains(x)) continue;
            
            ans.Add(x);
        }
        
        return ans.ToArray();
    }
}