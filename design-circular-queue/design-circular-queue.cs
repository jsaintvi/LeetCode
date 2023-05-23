public class MyCircularQueue {
    int[] data;
    int head_pos;
    int queue_size; // num of elems in queue

    int capacity; // num elems that queue can contain

    public MyCircularQueue(int k) {
        queue_size = 0;

        capacity = k;
        data = new int[k];
        head_pos = 0;
    }
    
    public bool EnQueue(int value) {
        if(IsFull()) return false;
        
        data[(head_pos + queue_size) % capacity] = value;
        queue_size++;

        return true;

    }
    
    public bool DeQueue() {
        if(IsEmpty()) return false;
        
        this.head_pos = (this.head_pos +1) % capacity;
        queue_size--;

        return true;
    }
    
    public int Front() {
        if(IsEmpty()) return -1;
        
        return data[head_pos];
    }
    
    public int Rear() {
        if(IsEmpty()) return -1;
        
        return data[(head_pos + queue_size -1) % capacity];
    }
    
    public bool IsEmpty() {
        return queue_size == 0;
    }
    
    public bool IsFull() {
        return queue_size == capacity;
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