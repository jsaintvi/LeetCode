public class Solution {
    public int Reverse(int x) {
        long res = 0;
        while(x != 0) {
            res = res * 10 + x % 10;
            x /= 10;
            
            // early exit
            if(res > int.MaxValue || res < int.MinValue) {
                return 0;
            }
        }
        
        return (int)res;
    }
}