public class Solution {
    public bool ValidMountainArray(int[] arr) {

        int n = arr.Length;
        int i = 0;
        
        // walk up
        while(i+1 < n && arr[i] < arr[i+1]) 
            i++;
        
        if(i == 0 || i == n -1)
            return false;
        
        // walk down
        
        while(i+1 < n && arr[i] > arr[i+1])
            i++;
        
        // if we reach end then valid
        return i == n-1;
    }
}