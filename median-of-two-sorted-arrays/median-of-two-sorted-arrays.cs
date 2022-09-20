public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {

        int[] mergedArr = Merge(nums1, nums2);
        
        int n = mergedArr.Length;
        
        if(n %2 != 0)
            return mergedArr[n/2] * 1.0;
        return (mergedArr[n/2] + mergedArr[n/2 -1]) * 1.0 / 2;
    }
    
    private int[] Merge(int[] nums1, int[]nums2) {
        int m = nums1.Length;
        int n = nums2.Length;
        
         int[] ans = new int[m+n];
        int arr1Idx= 0;
        int arr2Idx = 0;
        int k = 0;
        while(arr1Idx < m && arr2Idx < n) {
            if(nums1[arr1Idx] <= nums2[arr2Idx])
            {
                ans[k] = nums1[arr1Idx];
                arr1Idx++;
            } else {
                ans[k] = nums2[arr2Idx];
                arr2Idx++;
            }
            k++;
        }
        
        while(arr1Idx < m) {
            ans[k++] = nums1[arr1Idx++];
        }
        
        while(arr2Idx < n) {
            ans[k++] = nums2[arr2Idx++];
        }
        
        
        return ans;
    }
}