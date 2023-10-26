public class MinStack {
    private class Pair {
        public int Val {get;}
        public int Min{get;}
        
        public Pair(int val, int minElem) {
            this.Val = val;
            this.Min = minElem;
        }
    }

    Stack<Pair> stack;
    public MinStack() {
        stack = new();
    }
    
    public void Push(int x) {
        int min;
        if(stack.Count == 0) { // empty
            min = x;
        } else{
            Pair stackTop = stack.Peek();
            
            min = Math.Min(x, stackTop.Min);
        }
        
        stack.Push(new Pair(x, min));
    }
    
    public void Pop() {
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek().Val;
    }
    
    public int GetMin() {
        return stack.Peek().Min;
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