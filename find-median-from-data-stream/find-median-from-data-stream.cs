public class MedianFinder {

    PriorityQueue<int,int> min_pq;
    PriorityQueue<int,int> max_pq;

    private class NumComparer : IComparer<int> {
        public int Compare(int x, int y) {
            return y-x;
        }
    }
    
    public MedianFinder() {
        
        // store the larger half of the input numbers
        min_pq = new(); // can hold n elems
        
        // store the smaller half of the input numbers
        max_pq = new(new NumComparer()); // can hold, at worst, n+1 elems
    }
    
    public void AddNum(int num) {
        // add to max heap
        max_pq.Enqueue(num, num);
        
        // balancing heap step
        int largest_val = max_pq.Dequeue();
        min_pq.Enqueue(largest_val, largest_val);
        
        if(max_pq.Count < min_pq.Count) { // maintain size property
            int smallest_val = min_pq.Dequeue();
            max_pq.Enqueue(smallest_val, smallest_val);
        }
    }
    
    public double FindMedian() {
        if(max_pq.Count > min_pq.Count) {
            return max_pq.Peek();
        }else{
            return (double)(max_pq.Peek() + min_pq.Peek()) * 0.5;
        }
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */