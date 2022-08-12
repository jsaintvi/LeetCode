public class Solution {
    public int LengthOfLongestSubstring(string s) {
//         int n = s.Length;
//         int ans = 0;
        
//         Dictionary<char, int> map = new(); // stores curr index of char
        
//         for(int i = 0, j = 0; j < n; j++)
//         {
//             char curr = s[j];
//             //Console.WriteLine($"PRE: char {s[j]}. i {i} ------> j {j}");
//             if(map.ContainsKey(curr)) {
//                 i = Math.Max(i, map[curr]);
//             }
            
//             //Console.WriteLine($"POST: char {s[j]}. i {i} ------> j {j}");
//             ans = Math.Max(ans, j - i + 1);
            
//             if(!map.ContainsKey(s[j])) map.Add(curr, 0);
//             map[curr] = j+1;
//         }
        
//         return ans;
        
        int[] chars = new int[128];
        
        int left = 0;
        int right = 0;
        
        int res = 0;
        
        while(right < s.Length) {
            char r = s[right];
            chars[r]++;
            
            while(chars[r] > 1) {
                char l = s[left];
                chars[l]--;
                left++;
            }
            
            res = Math.Max(res, right - left +1);
            right++;
        }
        
        return res;
    }
}