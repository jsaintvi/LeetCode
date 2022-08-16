public class Solution {    
    public int ThirdMax(int[] nums) {

        HashSet<int> seen = new();
        
        foreach(var n in nums){
            seen.Add(n);
            
            if(seen.Count > 3){ //remove smallest elem
                int minVal = FindMinInSet(seen);
                seen.Remove(minVal);
            }
        }
        
        if(seen.Count ==3) {
            return FindMinInSet(seen);
        }
        
        return FindMaxInSet(seen);
    }
    
    private int FindMinInSet(HashSet<int> nums){
        int minNum = Int32.MaxValue;
        
        foreach(var n in nums){
            if(n < minNum)
                minNum = n;
        }
        
        return minNum;
    }
    
    private int FindMaxInSet(HashSet<int> nums){
        int maxNum = Int32.MinValue;
        
        foreach(var n in nums){
            if(n > maxNum)
                maxNum = n;
        }
        
        return maxNum;
    }
}