public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] ans = new int[n];
        
        Stack<int> st = new();
        
        for(int currDay = 0; currDay < n; currDay++) {
            // peek at top
            while(st.Count > 0 && temperatures[st.Peek()] < temperatures[currDay]) {
                int prevDay = st.Pop(); //prevDay
                ans[prevDay] = currDay - prevDay;
            }

            st.Push(currDay);
        }
        return ans;
    }
}