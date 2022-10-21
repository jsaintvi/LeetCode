public class Solution {
    public int DeleteAndEarn(int[] nums) {
        Dictionary<int,int> points = ComputePoints(nums);
        int maxNum = FindMax(nums);
        
        int[] maxPoints = new int[maxNum + 1];
        int twoBack = 0;
        int oneBack =  points.ContainsKey(1) ? points[1] : 0;
        
        for(int num = 2; num < maxPoints.Length; num++) {
            int temp = oneBack;
            
            int gain = points.ContainsKey(num) ? points[num] : 0;
            
            oneBack = Math.Max(oneBack, twoBack + gain);
            
            twoBack = temp;
        }
        return oneBack;
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
    
    private int FindMax(int[]nums){
        int maxNum = 0;
        foreach(int num in nums){
            maxNum = Math.Max(maxNum, num);
        }
        
        return maxNum;
    }
}