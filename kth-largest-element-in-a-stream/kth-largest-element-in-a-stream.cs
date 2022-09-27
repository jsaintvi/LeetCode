public class KthLargest {
    private readonly PriorityQueue<int,int> pq = new (); // min heap
    private readonly int pqSize;
    public KthLargest(int k, int[] nums) {
        this.pqSize = k;
        pq = new(pqSize);
        
        foreach(var num in nums)
            Add(num);
    }
    
    public int Add(int val) {
        pq.Enqueue(val, val);
        
        if(pq.Count > pqSize) pq.Dequeue();
        
        return pq.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */