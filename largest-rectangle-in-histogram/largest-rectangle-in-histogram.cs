public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int n = heights.Length;
        
        int largestArea = 0;

        Stack<int> st = new();
        st.Push(-1); // mark end of stack
        
        /*
        
        So the algorithm boils down to:

            Maintain a stack such that heights are always in increasing order.
            When we see a column that's lower than what's on the stack
            Use it as the right side and compute all the possible rectangles using what's on the stack to derive left side and height.
            Remove each considered rectangle / column from the stack
        */
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