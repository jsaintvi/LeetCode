public class Solution {
    public int LongestSubsequence(int[] arr, int difference) {

        Dictionary<int, int> map = new ();
        int ans = 0;
        // right - left = difference
        // -> left = right - difference -> Need to find left
        foreach (int right in arr) {
            int left = right - difference;
            
            int leftVal = map.ContainsKey(left) ? map[left] : 0;
            if(!map.ContainsKey(right)) map.Add(right, 0);
            
            map[right] =  leftVal + 1;
            ans = Math.Max(ans, map[right]);
        }
        return ans;
        
    }
}