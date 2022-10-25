public class Solution {
    private int[] nums;
    private int[] multipliers;
    private int[,] memo;
    private int numLen = 0;
    private int multiplierLen = 0;
    public int MaximumScore(int[] nums, int[] multipliers) {
        this.nums = nums;
        this.multipliers = multipliers;
        
        this.numLen = nums.Length;
        this.multiplierLen = multipliers.Length;
        
        this.memo = new int[multiplierLen, multiplierLen];

        return MaximumScore(0, 0);
    }
    
    private int MaximumScore(int pos, int leftIdx) {
        if(pos == multiplierLen) return 0;
        
        int mult = multipliers[pos];
        int right = numLen-1 - (pos - leftIdx);
        if(memo[pos,leftIdx] == 0 ){
            int takeLeft = mult * nums[leftIdx] + MaximumScore(pos + 1, leftIdx+1);
            int takeRight = mult * nums[right] + MaximumScore(pos + 1, leftIdx);
            memo[pos,leftIdx] = Math.Max(takeLeft,takeRight );
        }
        
        return memo[pos,leftIdx];
    }
}