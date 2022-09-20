public class Solution {
    public bool IsPerfectSquare(int num) {
//         if(num < 2) return true;
        
//         // when num > 2, sqrt of num is always less than num/2 and greater than 1
//         int left = 2;
//         int right = num/2;
        
//         while(left <= right) {
//             int mid = left + (right - left)/2;
            
//             int mid_squared = mid * mid;
            
//             if(mid_squared == num) return true;
            
//             if(mid_squared > num) 
//                 right = mid -1;
//             else
//                 left = mid+1;
//         }
        
//         return false;
        
       if (num == 1) return true;
        
        long low = 0, high = num / 2;
        while (low <= high) {
            long middle = low + (high - low) / 2;
            long square = middle * middle;
            if (square == num) return true;
            if (square < num) low = middle + 1;
            else high = middle - 1;
        }
        
        return false;
    }
    
}