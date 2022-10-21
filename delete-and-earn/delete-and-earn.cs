public class Solution {
    public int DeleteAndEarn(int[] nums) {
        Dictionary<int,int> points = ComputePoints(nums);
        int maxNum = MaxNum(nums);
        
        return MaxPoints(nums, maxNum, points, new Dictionary<int,int>());
    }
    
    private Dictionary<int,int> ComputePoints(int[]nums){
        Dictionary<int,int> points =  new();
        foreach(int num in nums){
            if(!points.ContainsKey(num))
                points.Add(num, 0);
            
            points[num]+= num;
        }
        
        return points;
    }
    
    private int MaxNum(int[]nums){
        int maxNum = 0;
        foreach(int num in nums){
            maxNum = Math.Max(maxNum, num);
        }
        
        return maxNum;
    }
    
    private int MaxPoints(int[] nums, int num, Dictionary<int,int> points, Dictionary<int,int> cache){
        if(num == 0) return 0;
        if(num == 1) 
            return points.ContainsKey(1) ? points[1] : 0;
        
        if(!cache.ContainsKey(num)){
            int gain = points.ContainsKey(num) ? points[num] : 0;
            
            int notTakeCurrNum = MaxPoints(nums, num-1, points, cache);
            int takeCurrNum = MaxPoints(nums, num-2, points, cache) + gain;
            var maxPoint =  Math.Max(notTakeCurrNum, takeCurrNum);
            cache.Add(num,maxPoint);
        }
            
        
        
        return cache[num];
    }
}