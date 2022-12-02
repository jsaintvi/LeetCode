public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int n = nums.Length;
        Dictionary<int,int> map = new();
        
        for(int i = 1; i <= n; i++) {
            map.Add(i, 0);
            Console.WriteLine($"Adding {i}");
        }
        foreach(var num in nums) {
            if(!map.ContainsKey(num)) continue;
            
            map[num]++;
        }
        
        // find first one missing
        
        foreach(var kv in map) {
            if(kv.Value == 0) return kv.Key;
        }
        return n+1;
        
    }
}