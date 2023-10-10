public class Solution {
    private readonly IList<IList<int>> output = new List<IList<int>>();
    public IList<IList<int>> Combine(int n, int k) {
        List<int> temp = new();
        KCombine(temp, 0, n, k);
        
        return output;
    }
    
    private void KCombine(List<int> temp, int start, int end, int k) {
        var index = temp.Count;
        if(index == k) {
            output.Add(new List<int>(temp));
            return;
        }
        
        for(int i = start; i < end ; i++) {
            temp.Add(i + 1);
            KCombine(temp, i + 1, end, k);
            
            // remove last elem for backtracking
            temp.RemoveAt(temp.Count - 1);
        }
    }
}