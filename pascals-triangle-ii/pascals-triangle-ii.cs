public class Solution {
    public IList<int> GetRow(int rowIndex) {
        
        List<int> ans = new List<int>();
        for(int i = 0; i <= rowIndex; i++)
            ans.Add(1);
        
        for(int i = 1; i < rowIndex; i++) {
            for(int j = i; j > 0; j--) {
                ans[j] += ans[j-1];
            }
        }
        
        return ans;
    }
}