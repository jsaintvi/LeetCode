public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int n = heights.Length;
        
        int largestArea = 0;

        Stack<int> st = new();
        st.Push(-1); // mark end of stack
        
        for(int i = 0; i < n; i++) {
            while(st.Peek() != -1 && heights[st.Peek()] >= heights[i]) {
                int curr_height = heights[st.Peek()];
                st.Pop();
                
                int curr_width = i - st.Peek() - 1;
 
                largestArea = Math.Max(largestArea, curr_height * curr_width);
            }
            
            st.Push(i);
        }
        
        while(st.Peek() != -1) {
            int curr_height = heights[st.Peek()];
            st.Pop();
            int curr_width = n - st.Peek() - 1;
            largestArea = Math.Max(largestArea, curr_height * curr_width);
        }
        
        return largestArea;
    }
}