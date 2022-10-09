public class Solution {
    public int ClimbStairs(int n) {
        if(n == 1) return 1;
        
        int first = 1;
        int second = 2;
        
        for(int i = 3; i <= n; i++) {
            int third = first + second;
            
            // advance step
            first = second;
            second = third;
        }
        
        return second;
    }
}