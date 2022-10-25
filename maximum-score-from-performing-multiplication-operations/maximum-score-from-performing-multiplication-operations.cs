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

        return MaximumScore(0, 0, numLen-1);
    }
    
    private int MaximumScore(int pos, int leftIdx, int rightIdx) {
        if(pos == multiplierLen) return 0;
        
        int mult = multipliers[pos];
        if(memo[pos,leftIdx] == 0 ){
            int takeLeft = mult * nums[leftIdx] + MaximumScore(pos + 1, leftIdx+1, rightIdx);
            int takeRight = mult * nums[rightIdx] + MaximumScore(pos + 1, leftIdx, rightIdx-1);
            memo[pos,leftIdx] = Math.Max(takeLeft,takeRight );
        }
        
        return memo[pos,leftIdx];
    }
}