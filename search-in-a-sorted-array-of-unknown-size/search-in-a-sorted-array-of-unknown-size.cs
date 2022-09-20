/**
 * // This is ArrayReader's API interface.
 * // You should not implement it, or speculate about its implementation
 * class ArrayReader {
 *     public int Get(int index) {}
 * }
 */

class Solution {
    public int Search(ArrayReader reader, int target) {
        if(reader.Get(0) == target) return 0;
        
        int left = 0;
        int right = 1;
        
        // determine boudaries
        while(reader.Get(right) < target) {
            left = right;
            right *= 2;
        }
        
        while(left <= right) {
            int midIdx = left + (right - left) /2;
            int midVal = reader.Get(midIdx);
            
            if(midVal == target) return midIdx;
            if(target < midVal) {
                right = midIdx-1;
            }else{
                left = midIdx +1;
            }
            
        }
        
        return -1;
    }
}