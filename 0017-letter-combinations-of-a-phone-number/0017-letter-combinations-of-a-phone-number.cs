public class Solution {
    public static string[] map = new string[]{ "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
    
    public IList<string> LetterCombinations(string digits) {
        IList<string> combinations = new List<string>();
        
        if (digits == null || digits.Length == 0) {
            return combinations;
        }
        
        Backtrack(digits, 0, new char[digits.Length], combinations);
        return combinations;
    }
    
    /// <summary>
    /// The Backtrack function iterates through each digit in the input string and for each digit, 
    /// it gets the corresponding letters from the map array. 
    /// It then iterates through each letter and appends it to the current combination. 
    /// After appending a letter, it recursively calls the Backtrack function with the index of the next digit.
    /// </summary>
    private void Backtrack(string digits, int index, char[] curr, IList<string> combinations) {
        if(index == digits.Length){
            combinations.Add(new String(curr));
            return;
        }
        
        int digit = digits[index] - '0';
        string letters = map[digit];
        
        for(int i = 0; i < letters.Length; i++) {
            curr[index] = letters[i];
            Backtrack(digits, index + 1, curr, combinations);
        }
    }
}