public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        int len = nums.Length;
                
        IList<IList<int>> ans = new List<IList<int>>();
        
        HeapPermutations(nums, nums.Length, (nums)=> ans.Add(nums));
        
        return ans;
    }
    
       
    private void HeapPermutations(int[]nums, int size, Action<List<int>> process) {
        
        if(size == 1) {
            process(nums.ToList());
        }
            
        for(int i = 0; i < size; i++) {
            HeapPermutations(nums, size -1, process);
            
            if(size % 2 == 1) {
                Swap(nums, 0, size-1);
            } else {
                Swap(nums, i, size-1);
            }
        }
    }
    
    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}