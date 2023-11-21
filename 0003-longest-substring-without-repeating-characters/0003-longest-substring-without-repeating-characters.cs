public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (string.IsNullOrEmpty(s)) return 0;
        if (s.Length == 1) return 1;

        int left = 0;
        int right = 0;
        int result = 0;
        HashSet<char> set = new HashSet<char>();

        while (right < s.Length) {
            if (!set.Contains(s[right])) {
                set.Add(s[right]);
                right++;
                result = Math.Max(result, right - left);
            } else {
                set.Remove(s[left]);
                left++;
            }
        }

        return result;
    }
}