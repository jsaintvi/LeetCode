public class Solution {
    public int LastStoneWeight(int[] stones) {
        //Time Complexity: O(NLogN)
        // Space Complexity: O(N)
        
        // max heap
        PriorityQueue<int,int> pq = new(new StoneComparer());
        foreach(int stone in stones)
            pq.Enqueue(stone, stone);
        
        while(pq.Count > 1) {
            int stone1 = pq.Dequeue();
            int stone2 = pq.Dequeue();
            
            if(stone1!= stone2) {
                int newWeight = stone1 - stone2;
                pq.Enqueue(newWeight, newWeight);
            }
        }
        
        if(pq.Count == 0)
            return 0;
        
        return pq.Dequeue();
    }
    
    private class StoneComparer : IComparer<int> {
        public int Compare(int x, int y) {
            return y-x;
        }
    }
}