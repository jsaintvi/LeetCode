public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        
        // Fix the first element as A[i] 
        IList<IList<int>>res = new List<IList<int>>();
        int n = nums.Length;
        if(n == 0) return res;
        
        Array.Sort(nums);
        
         for (int i = 0; i < n; i++) 
            {
                if(i-1 >= 0 && nums[i] == nums[i-1])
                    continue;
                int ptr_1 = i+1, ptr_2 = n-1;
                while(ptr_1 < ptr_2) {
                    int curr_sum = nums[i] + nums[ptr_1] + nums[ptr_2];
                    
                    if(curr_sum == 0) {
                        var to_add = new List<int>{nums[i], nums[ptr_1], nums[ptr_2]}; 
                        res.Add(to_add);
                        
                        // skip dupes
                        while (ptr_1 + 1 < ptr_2 && nums[ptr_1] == nums[ptr_1+1])
                            ptr_1++;
                        
                        while (ptr_2-1 > ptr_1 && nums[ptr_2] == nums[ptr_2-1])
                            ptr_2--;

                        ptr_1++;
                        ptr_2--;
                    }else if(curr_sum > 0) {
                        ptr_2--;
                    } else {
                        ptr_1++;
                    }
                    
                }
            }
        
        return res;
    }
    
}