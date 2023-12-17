public class Solution {
    public int[] FrequencySort(int[] nums) {
        var dict = new Dictionary<int, int>();
        
        foreach(var num in nums)
        {
            if(dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict[num] = 1;
            }
        }
        
        Array.Sort(nums, (x,y)=> {
            if (dict[x] == dict[y])
                return y-x;
            return dict[x] - dict[y];
        });

        return nums;
    }
}