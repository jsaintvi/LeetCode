public class Solution {
    public int ThirdMax(int[] nums) {
        HashSet<int> s = new(nums);
        
        return FindKMax(s, 3);
    }
    
    private int FindKMax(HashSet<int> s, int k) {
        int maxNum = Int32.MinValue;
        
        PriorityQueue<int,int> pq = new ();
        foreach(var n in s){
            pq.Enqueue(n,n);
            
            if(pq.Count > 3)
                pq.Dequeue();
        }
        

        if(pq.Count ==1)
            return pq.Peek();
        else if(pq.Count == 2) {
            int firstNum = pq.Dequeue();
            
            return Math.Max(firstNum, pq.Peek());
        }
        
        return  pq.Peek();
    }
    
    private class MaxComparer : IComparer<int> {
        public int Compare(int x, int y) {
            return y-x;
        }
    }
}