public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;
        
        // asume first element is unique
        int insertIndex = 1;
        for (int j = 1; j < nums.Length; j++) {
            if(nums[j] == nums[j-1]) continue; // skip over dupes

            nums[insertIndex++] = nums[j];
        }
        
        return insertIndex;
    }
}