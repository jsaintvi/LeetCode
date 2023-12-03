public class MyQueue {

    Stack<int> stackNewest, stackOldest;
    
    public MyQueue() {
        stackNewest = new Stack<int>();
        stackOldest = new Stack<int>();
    }
    
    public void Push(int x) {
        stackNewest.Push(x);
    }
    
    public int Pop() {
        TryPerformStackReset();
        return stackOldest.Pop();
    }
    
    public int Peek() {
        TryPerformStackReset();
        return stackOldest.Peek();
    }
    
    public bool Empty() {
        return stackNewest.Count == 0 && stackOldest.Count == 0;
    }
    
    private void TryPerformStackReset(){
        if (stackOldest.Count == 0) {
            while (stackNewest.Count > 0) {
                stackOldest.Push(stackNewest.Pop());
            }
        }
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */