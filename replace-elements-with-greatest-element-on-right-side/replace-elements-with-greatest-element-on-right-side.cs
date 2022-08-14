public class Solution {
    public int[] ReplaceElements(int[] arr) {
        
        int n = arr.Length;
        int currentMax = arr[n - 1];
        for (var i = arr.Length - 1; i >= 0; i--) {
            
            var temp = arr[i];
            if (arr[i] > currentMax) {
                arr[i] = currentMax;
                currentMax = temp;
            } else {
                arr[i] = currentMax;
            }
            
        }
        
        arr[n-1] = -1;
        return arr;
    }
}