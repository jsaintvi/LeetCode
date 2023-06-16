public class Solution {
    public int EvalRPN(string[] tokens) {
     Stack<int> st =new();
        
        foreach(string token in tokens) {
            
            int first = 1;
            int second = 1;
            switch(token) {
                case "+" :
                    first = (int)st.Pop();
                    second = (int)st.Pop();
                    st.Push(Add(second, first));
                    break;
                case "-":
                    first = (int)st.Pop();
                    second = (int)st.Pop();
                    st.Push(Substract(second, first));
                    break;
                case "*":
                    first = (int)st.Pop();
                    second = (int)st.Pop();
                    st.Push(Multiply(second, first));
                    break;
                case "/":
                    first = (int)st.Pop();
                    second = (int)st.Pop();
                    st.Push(Divide(second, first));
                    break;
                default:
                    st.Push(int.Parse(token));
                    break;
            }
        }
        
        Console.WriteLine($"Stack contains {st.Count} elems");
        return st.Pop();
    }
    
    
    private int Add(int x, int y) {
        return x+y;
    }
    
    private int Substract(int x, int y) {
        return x - y;
    }
    
    private int Multiply(int x, int y)
    {
        return x*y;
    }
    
    private int Divide(int x, int y){
        return x/y;
    }
}