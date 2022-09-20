public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0;
        int j = numbers.Length - 1;
        
        int[] ans = new int[2];
        while(i <= j)
        {
            int currSum = numbers[i] + numbers[j];
            
            if(currSum == target)
            {
                ans[0] = i+1;
                ans[1] = j + 1;
                break;
            }else if(currSum > target)
            {
                j-= 1;
            }else{
                i+= 1;
            }
        }
        
        return ans;
    }
}