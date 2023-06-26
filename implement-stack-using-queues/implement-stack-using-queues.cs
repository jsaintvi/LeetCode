public class MyStack {

    Queue<int> q1;
    Queue<int> q2;
    
    int front = -1;
    public MyStack() {
        q1 = new();
        q2 = new();
    }
    
    public void Push(int x) {        
        q1.Enqueue(x);
        
        front = x;
    }
    
    public int Pop() {
       while(q1.Count > 1) {
           front = q1.Peek();
           q2.Enqueue(q1.Dequeue());
       }

       var lastElem = q1.Dequeue();

       while(q2.Count > 0){
           q1.Enqueue(q2.Dequeue());
       }

       return lastElem;
    }
    
    public int Top() {
       return front;
    }
    
    public bool Empty() {
        return q1.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */