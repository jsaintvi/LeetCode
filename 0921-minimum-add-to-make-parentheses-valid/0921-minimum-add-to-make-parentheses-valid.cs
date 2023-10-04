public class Solution {
    public int MinAddToMakeValid(string s) {
      int result = 0;
        int count = 0;
        foreach(char c in s){
            if (c.ToString() == "(")
                count++;
            else if (c.ToString() == ")")
                count--;
            
            if (count < 0){ // missing bracket (unbalanced)
                result++;
                count = 0;
            }  
        }
        
        if (count > 0)
           result += count;

        return result;
    }
}