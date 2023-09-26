public class MyCircularDeque {

    private readonly int size;
    private readonly LinkedList<int> ll;
    public MyCircularDeque(int k) {
        size = k;
        
        ll = new();
    }
    
    public bool InsertFront(int value) {
        if(!IsFull())
        {
            ll.AddFirst(value);
            return true;
        }
        
        return false;
    }
    
    public bool InsertLast(int value) {
        if(!IsFull())
        {
            ll.AddLast(value);
            return true;
        }
        
        return false;
    }
    
    public bool DeleteFront() {
        if(!IsEmpty()) {
            ll.RemoveFirst();
            return true;
        }
        
        return false;
    }
    
    public bool DeleteLast() {
        if(!IsEmpty()) {
            ll.RemoveLast();
            return true;
        }
        
        return false;
    }
    
    public int GetFront() {
        if(!IsEmpty())
        {
            return ll.First.Value;
        }
        
        return -1;
    }
    
    public int GetRear() {
        if(!IsEmpty())
        {
            return ll.Last.Value;
        }
        
        return -1;
    }
    
    public bool IsEmpty() {
        return ll.Count == 0;
    }
    
    public bool IsFull() {
        return ll.Count == size;
    }
}

/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque obj = new MyCircularDeque(k);
 * bool param_1 = obj.InsertFront(value);
 * bool param_2 = obj.InsertLast(value);
 * bool param_3 = obj.DeleteFront();
 * bool param_4 = obj.DeleteLast();
 * int param_5 = obj.GetFront();
 * int param_6 = obj.GetRear();
 * bool param_7 = obj.IsEmpty();
 * bool param_8 = obj.IsFull();
 */