public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        int n = letters.Length;
        int low = 0;
        int high = n -1;
        
        while(low <= high) {
            int mid = low + (high - low)/2;
            
            if(letters[mid] <= target)
                low = mid+1;
            else
                high = mid-1;
        }
        
        return letters[low % n];
        
    }
}