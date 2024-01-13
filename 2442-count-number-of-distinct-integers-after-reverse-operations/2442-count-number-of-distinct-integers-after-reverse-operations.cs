public class Solution {
    public int CountDistinctIntegers(int[] nums) {
        
        int n = nums.Length;
        
        
        HashSet<int> numSet = new();
        foreach(var num in nums) {
            
            var reversed = ReverseDigit(num);
            
            
            //Console.WriteLine($"Num: {num} - Reversed {reversed}");
            numSet.Add(num);
            numSet.Add(reversed);
        }
        
        return numSet.Count;
    }
    

    private int ReverseDigit(int num) {
        int reverse = 0;
        
        while(num != 0) {
            reverse = reverse * 10 + num % 10;
            
            num /= 10;
        }
        
        return reverse;
    }
}