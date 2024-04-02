public class Solution {
    public int FindGCD(int[] nums) {
        int smallestNum = int.MaxValue;
        int largestNum = int.MinValue;
        
        foreach(var num in nums)
        {
            smallestNum = Math.Min(smallestNum, num);
            largestNum = Math.Max(largestNum, num);
        }
        
        return GCD(smallestNum, largestNum);
    }
    
    int GCD(int a, int b)
    {
        while(b != 0)
        {
            // a is now b
            // b is now the remainder
            
            int temp = b;
            b = a%b;
            
            a = temp;
        }
        
        return a;
    }
}