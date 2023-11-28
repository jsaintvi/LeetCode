public class Solution {
    public string IntToRoman(int num) {
        StringBuilder romanNumber = new StringBuilder();

        Dictionary<int, string> intToRomanMap = new(){
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };
        
        foreach ( var @key in intToRomanMap.Keys)
        {
            while (num >= @key)
            {
                romanNumber.Append(intToRomanMap[@key]);
                num -= @key;
            }
        }

        return romanNumber.ToString();
    }
}