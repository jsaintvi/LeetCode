public class Solution {
    public int[] SortArray(int[] nums) {
        if(nums.Length <2) return nums;
        
        MergeSort(nums, 0, nums.Length-1);
        return nums;
    }
    
            public void MergeSort(int[] arr, int low, int high) 
        { 
            if (low < high) 
            { 
                // Same as (l+r)/2, but avoids overflow for 
                // large l and h 
                int mid = low+(high-low)/2; 
  
                // Sort first and second halves 
                MergeSort(arr, low, mid); 
                MergeSort(arr, mid+1, high); 
  
                Merge(arr, low, mid, high); 
            } 
        } 

        // Merges two subarrays of arr[]. 
        // First subarray is arr[l..m] 
        // Second subarray is arr[m+1..r]
        private void Merge(int[] arr, int low, int mid, int high) 
        { 
            int i, j, k; 
            
            int n1 = mid - low + 1; // elemts in first subaaray
            int n2 =  high - mid;  // elemtnts in second subaaray
  
            /* create temp arrays */
            var L = new int[n1];
            var R = new int[n2]; 
  
            /* Copy data to temp arrays L[] and R[] */
            for (i = 0; i < n1; i++) 
                L[i] = arr[low + i]; 
            
            for (j = 0; j < n2; j++) 
                R[j] = arr[mid + 1+ j]; 
  
            /* Merge the temp arrays back into arr[l..r]*/
            i = 0; // Initial index of first subarray 
            j = 0; // Initial index of second subarray 
            k = low; // Initial index of merged subarray 
            while (i < n1 && j < n2) 
            { 
                if (L[i] <= R[j]) 
                { 
                    arr[k] = L[i]; 
                    i++; 
                } 
                else
                { 
                    arr[k] = R[j]; 
                    j++; 
                } 
                k++; 
            } 
  
            /* Copy the remaining elements of L[], if there 
               are any */
            while (i < n1) 
            { 
                arr[k] = L[i]; 
                i++; 
                k++; 
            } 
  
            /* Copy the remaining elements of R[], if there 
               are any */
            while (j < n2) 
            { 
                arr[k] = R[j]; 
                j++; 
                k++; 
            } 
        } 
}