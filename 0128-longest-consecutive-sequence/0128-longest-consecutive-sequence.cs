public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums == null || nums.Length == 0)
            return 0;
        
        HashSet<int> s = new(nums);
        
        int longestStreak = 0;
        foreach(var num in nums){
            if(s.Contains(num-1)) // num not start of sequence
                continue;
            
            int currentStreak = 1;
            int currNum = num;
            while(s.Contains(currNum + 1)) {
                
                currentStreak += 1;
                currNum += + 1;
            }
            
            longestStreak = Math.Max(longestStreak, currentStreak);
        }
        
        return longestStreak;
    }
}