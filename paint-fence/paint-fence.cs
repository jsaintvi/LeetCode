public class Solution {
    public int NumWays(int n, int k) {
       
        if(n==1)
            return k;
        if(n==2)
            return k*k;
        
        int backTwoSteps = k;
        int backOneStep = k*k;
        
        for(int i = 3; i <= n; i++) {
            int curr = (k-1) * (backOneStep + backTwoSteps);;
            backTwoSteps = backOneStep;
            backOneStep = curr;
            
        }
        return backOneStep;
    }
}