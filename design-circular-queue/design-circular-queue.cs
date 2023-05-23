public class MyCircularQueue {
    
    Node head;
    Node tail;

    int queue_size;
    int capacity; // num elems that queue can contain

    public MyCircularQueue(int k) {
        queue_size = 0;
        capacity = k;
    }
    
    public bool EnQueue(int value) {
        if(IsFull()) return false;
        
        var newNode = new Node(value);

        if(IsEmpty())
        {
            head = tail = newNode;
        }else{
            tail.NextNode = newNode;
            tail = tail.NextNode;
        }
        queue_size++;

        return true;

    }
    
    public bool DeQueue() {
        if(IsEmpty()) return false;
        
        this.head = this.head.NextNode;
        queue_size--;

        return true;
    }
    
    public int Front() {
        if(IsEmpty()) return -1;
        
        return head.Value;
    }
    
    public int Rear() {
        if(IsEmpty()) return -1;
        
        return tail.Value;
    }
    
    public bool IsEmpty() {
        return queue_size == 0;
    }
    
    public bool IsFull() {
        return queue_size == capacity;
    }

    private class Node{
        public int Value{get; set;}
        public Node NextNode {get;set;}

        public Node(int val){
            this.Value = val;
            this.NextNode = null;
        }
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */