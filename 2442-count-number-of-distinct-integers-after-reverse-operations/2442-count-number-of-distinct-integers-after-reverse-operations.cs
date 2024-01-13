public class Solution {
    public int CountDistinctIntegers(int[] nums) {
        
        int n = nums.Length;
        List<int> lst = new List<int>();
        
        
        foreach(var num in nums) {
            
            var reversed = ReverseDigit(num);
            
            //Console.WriteLine($"Num: {num} - Reversed {reversed}");
            lst.Add(num);
            lst.Add(reversed);
        }
        
        HashSet<int> numSet = new();
        
        int distinctCount = 0;
        foreach(var x in lst){
            if(numSet.Contains(x)) continue;
            
            
            distinctCount+=1;
            
            numSet.Add(x);
        }
        
        
        return distinctCount;
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