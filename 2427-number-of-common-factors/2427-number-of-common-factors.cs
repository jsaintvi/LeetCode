public class Solution {
    public int CommonFactors(int a, int b) {
        int max = Math.Min(a,b);
        
        int count = 0;
        for(int i = 1; i <= max; i++) {
            if(a % i == 0 && b %i == 0)
            {
                count++;
            }
        }
        
        return count;
    }
}