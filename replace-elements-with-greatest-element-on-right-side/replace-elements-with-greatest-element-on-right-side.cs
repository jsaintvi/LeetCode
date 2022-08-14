public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int n = arr.Length;
        
        if(n==1){
            arr[n-1] = -1;
            
            return arr;
        }
        
        for(int i= arr.Length-1; i > 0; i--)
        {
            if (arr[i] > arr[i-1]) 
                arr[i-1] = arr[i];
        }
        
        for(int i=1; i<arr.Length; i++)
        {
            arr[i-1] = arr[i];
        }
        arr[arr.Length -1] = -1;
        return arr;
    }
}