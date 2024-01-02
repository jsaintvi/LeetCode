public class Solution {
    public IList<IList<int>> FindMatrix(int[] nums) {
        
        // store freq of integers in 'nums'
        int[] freq = new int[nums.Length + 1]; 
        
        List<IList<int>> ans = new();
        foreach(var num in nums) {
            if(freq[num] >= ans.Count) {
                ans.Add(new List<int>());
            }
            
            ans[freq[num]].Add(num);
            freq[num]++;
        }
        
        return ans;
    }
}