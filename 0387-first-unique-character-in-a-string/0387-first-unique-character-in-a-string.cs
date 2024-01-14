public class Solution {
    private class CharInfo{
        public int Index {get;set;}
        public int Count {get;set;}
    }
    public int FirstUniqChar(string s) {
        if (string.IsNullOrEmpty(s))
        {
            return -1;
        }

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        // Count occurrences of each character in the string
        foreach (char c in s)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        // Find the first non-repeating character and return its index
        for (int i = 0; i < s.Length; i++)
        {
            if (charCount[s[i]] == 1)
            {
                return i;
            }
        }

        return -1; // No unique character found
    }
}