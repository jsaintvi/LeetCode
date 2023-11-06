public class Solution {
    public int ThirdMax(int[] nums) {
        //HashSet<int> s = new(nums);
        SortedSet<int> s = new();
        
        foreach(var n in nums) {
            if(s.Contains(n))
                continue;
            
            if(s.Count == 3) {
                if(s.Min < n) {
                    s.Remove(s.Min());
                    s.Add(n);
                }

            } else{
               s.Add(n); 
            }
            
        }
        
        if(s.Count == 3)
            return s.Min();
        
        return s.Max();
    }

}