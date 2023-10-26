public class MinStack {
    private class Node {
        public int Val {get;}
        public int Min{get;}
        
        public Node Next {get;set;}
        
        public Node(int val, int minElem, Node next = null) {
            this.Val = val;
            this.Min = minElem;
            Next = next;
        }
    }

    Node head = null;
    public MinStack() {
        head = null;
    }
    
    public void Push(int x) {
        int min;
        
        if(head == null) {
            head = new Node(x, x);
        } else {
            head = new Node(x, Math.Min(head.Min, x), head);
        }
    }
    
    public void Pop() {
        head = head.Next;
    }
    
    public int Top() {
        return head.Val;
    }
    
    public int GetMin() {
        return head.Min;
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