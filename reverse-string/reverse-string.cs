public class Solution {
    public void ReverseString(char[] s) {
        int i = 0;
        int j = s.Length - 1;
        
        while(i <= j)
        {
            Swap(s, i, j);
            i++;
            j--;
        }
    }
    
    private void Swap(char[] s, int x, int y)
    {
        char temp = s[x];
        s[x] = s[y];
        s[y] = temp;
    }
}