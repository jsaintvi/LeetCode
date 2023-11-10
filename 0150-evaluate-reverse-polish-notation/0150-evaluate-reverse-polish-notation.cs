public class Solution {
    public int EvalRPN(string[] tokens) {
     Stack<int> st =new();
        
        foreach(string token in tokens) {
            switch(token) {
                case "+" :
                    st.Push(st.Pop() + st.Pop());
                    break;
                case "-":
                    st.Push( - st.Pop() + st.Pop());
                    break;
                case "*":
                    st.Push(st.Pop() * st.Pop());
                    break;
                case "/":
                    int denominator = st.Pop();
                    int numerator = st.Pop();
                    st.Push(numerator / denominator);
                    break;
                default:
                    st.Push(int.Parse(token));
                    break;
            }
        }
        
        return st.Pop();
    }
}