public class Solution {
    public int[] FrequencySort(int[] nums) {
        Dictionary<int,int> hash = new();
        foreach(var num in nums){
            if(!hash.ContainsKey(num)) hash.Add(num, 0);
            
            hash[num] += 1;
        }
        
        var sortedArray = nums.OrderBy(x => hash[x]).ThenBy(x => -x).ToArray();
        return sortedArray;
    }
}