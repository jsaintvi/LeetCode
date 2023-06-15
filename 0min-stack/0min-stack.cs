public class MinStack {


    Stack<int> stack;
    Stack<int> minStack;
    public MinStack() {
        stack = new();
        minStack = new();

    }
    
    public void Push(int x) {
        if(minStack.Count == 0) { // empty
            minStack.Push(x);
        } else {
            minStack.Push(Math.Min(x, minStack.Peek()));
        }
        
        stack.Push(x);
    }
    
    public void Pop() {
        minStack.Pop();
        stack.Pop();

    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */