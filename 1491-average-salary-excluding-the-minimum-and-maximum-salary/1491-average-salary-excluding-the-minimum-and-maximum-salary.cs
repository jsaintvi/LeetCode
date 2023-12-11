public class Solution {
    public double Average(int[] salary) {
        int minSalary = int.MaxValue;
        int maxSalary = int.MinValue;
        
        long total = 0;
        foreach(var x in salary) {
            total += x;
            
            minSalary = Math.Min(minSalary, x);
            maxSalary = Math.Max(maxSalary, x);
        }
        
        total -= (minSalary + maxSalary);
        
        return total / (salary.Length - 2 / 1.0);
    }
}