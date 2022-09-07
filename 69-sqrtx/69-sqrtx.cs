public class Solution {
    public int MySqrt(int x) {
        if(x < 2) return x;
        
        
        int left = 2;
        int right = x/2;
        
        while(left <= right) {
            int mid = left + (right - left)/2;
            long num_squared = (long)mid * mid;
            
            if(num_squared == x) {
                return mid;
            }else if(num_squared > x) {
                right = mid - 1;
            }else {
                left = mid+1;
            }
        
        }
        
        return right;
    }
}