public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int n = arr.Length;
        
        if(n == 1) {
            arr[0] = -1;
            
            return arr;
        } 
        
        for(int i = 0; i < n; i++ ) {
            int maxSoFar = -1;
            for(int j = i+1; j < n; j++) {
                if(arr[j] > maxSoFar) {
                    maxSoFar = arr[j];
                }
            }
            
            arr[i] = maxSoFar;
        }
        
        arr[n-1] =-1;
        return arr;
    }
}