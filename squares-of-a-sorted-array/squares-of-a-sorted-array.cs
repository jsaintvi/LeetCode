public class Solution {
    public int[] SortedSquares(int[] nums) {
        int len = nums.Length;
        int[] ans = new int[len];
        
        int i = 0;
        int j = len - 1;
        

        for(int pos = len-1; pos >= 0; pos--){
            int smaller = nums[i];
            int larger = nums[j];
            
            
            if( Math.Abs(smaller) > Math.Abs(larger) ) {
                ans[pos] = smaller * smaller;
                i++;
            }
            else {

                ans[pos] = larger * larger;
                j--;
            }
        }
               
       return ans;
    }
}