public class Solution {
    public string IntToRoman(int num) {
        string[] romanDigits = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] decimalValues = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        StringBuilder romanNumber = new StringBuilder();

        for (int i = 0; i < decimalValues.Length; i++)
        {
            while (num >= decimalValues[i])
            {
                romanNumber.Append(romanDigits[i]);
                num -= decimalValues[i];
            }
        }

        return romanNumber.ToString();
    }
}