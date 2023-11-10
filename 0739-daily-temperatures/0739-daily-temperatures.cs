public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] ans = new int[n];
        
        Stack<int> st = new();
        
        for(int currDay = 0; currDay < n; currDay++) {
            // peek at top
            while(st.TryPeek(out int prevDay) && temperatures[prevDay] < temperatures[currDay]) {
                ans[prevDay] = currDay - prevDay;
                
                st.Pop();
            }

            st.Push(currDay);
        }
        return ans;
    }
}