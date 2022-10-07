public class Solution {
    public void ReverseString(char[] s) {
        ReverseString(s, 0, s.Length -1);
    }
    
    private void ReverseString(char[] s, int l, int r){
        if(l >= r) return;
        
        char temp = s[l];
        s[l] = s[r];
        s[r] = temp;
        l++;
        r--;
        
        ReverseString(s, l, r);   
    }
}