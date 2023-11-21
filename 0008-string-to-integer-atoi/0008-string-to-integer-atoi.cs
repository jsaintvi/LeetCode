public class Solution {
    public int MyAtoi(string s) {
        int n = s.Length, i = 0;
        
        // skip white spaces
        while(i < n && s[i] == ' ') 
            i++;
        
        // check sign
        int sign = 1;
        if(i < n && (s[i] == '+' || s[i] == '-')) {
            if(s[i] == '-') 
                sign = -1;
            i++;
        }
        
        // convert number and check for overflow
        int total = 0;
        while(i < n && char.IsDigit(s[i])) {
            int digit = s[i] - '0';
            if(int.MaxValue / 10 < total || int.MaxValue / 10 == total && digit > 7) 
                return sign == 1 ? int.MaxValue : int.MinValue;
            total = total * 10 + digit;
            i++;
        }
        
        return sign * total;
    }
}