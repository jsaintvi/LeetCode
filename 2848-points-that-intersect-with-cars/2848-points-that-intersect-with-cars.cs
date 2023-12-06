public class Solution {
    public int NumberOfPoints(IList<IList<int>> nums) {        
        var mergedList = Merge(nums.ToList());
        
        int res = 0;
        foreach(var x in mergedList)
        {
            for(int i = x[0]; i <= x[1]; i++) {
                res += 1;
            }
        }
        
        return res;
    }
    
    private void PrintLit(IList<IList<int>> nums) {
        foreach(var l in nums) {
            Console.WriteLine($"[{l[0]},{l[1]}]");
        }
    }
    
    private int[][] Merge(List<IList<int>> intervals) {
        
        intervals.Sort( (a,b) => a[0] - b[0] );
        List<int[]> result = new();
        
        foreach(var interval in intervals)
        {
            if (result.Count == 0)
            {
                result.Add(interval.ToArray());
                continue;
            }
            
            if (interval[0] <= result[result.Count - 1][1]) // does it overlap?
            {
                result[result.Count - 1][1] = Math.Max(result[result.Count - 1][1], interval[1]);
            }
            else
            {
                result.Add(interval.ToArray());
            }
        }
        return result.ToArray();
    }
}