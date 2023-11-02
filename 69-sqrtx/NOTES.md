# Thougth process
The square root of any number is at most half of that number (n/2). So we start from lower bound (left bound) at 2, and rightmost bound is set to n/2.

## At every step, we determine the mid point
Mid: left + (right - left)/2;  
1. [ ] **Case 1**: mid * mid = sqrt , we have found it - that mid is the sqrt of that number (why, sqrt of a number is the number * number),
2. [ ] **Case 2**: mid * mid > x, that sqrtData will be in the left portion (right = mid - 1) 
3. [ ] **Case 3**: mid * mid < x: that sqrtData will be in the right portion (left = mid + 1)  