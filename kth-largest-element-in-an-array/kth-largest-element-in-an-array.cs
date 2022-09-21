public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        // min heap with k elems
        PriorityQueue<int,int> pq = new (k);
        foreach(int num in nums) {
            if(pq.Count < k) {
                pq.Enqueue(num, num);
            }else{
                var top = pq.Peek();
                
                if(num > top) {
                    pq.EnqueueDequeue(num, num);
                }
            }
        }
        
        return pq.Peek();
    }
}