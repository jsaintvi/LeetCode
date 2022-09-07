/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is lower than the guess number
 *			      1 if num is higher than the guess number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int left = 1, right = n, ans = -1;
        
        while(left <= right){
            int mid = left + (right - left) /2;
            
            int guessedNumber = guess(mid);
            if(guessedNumber == 0){
                return mid;
            }else if(guessedNumber == 1){
                left = mid + 1;
            } else{
                right = mid - 1;
            }
        }
        
        return -1;
    }
}