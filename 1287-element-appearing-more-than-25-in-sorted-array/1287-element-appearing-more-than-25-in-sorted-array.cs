public class Solution {
    public int FindSpecialInteger(int[] arr) {
        var n = arr.Length;
        var number = arr[0];
        var numberOfOccurance = 1;
        var percent = 1.0 / 4.0 * n;

        for (int i = 1; i < n; ++i)
        {
            if (numberOfOccurance > percent)
            {
                return number;
            }
            
            if (arr[i] == number)
            {
                ++numberOfOccurance;
            }
            else
            {
                // reset as its 'new' number
                numberOfOccurance = 1;
                number = arr[i];
            }
        }
        return number;
    }
}