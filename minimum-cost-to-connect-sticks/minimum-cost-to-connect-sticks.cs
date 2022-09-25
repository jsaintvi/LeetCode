public class Solution {
    public int ConnectSticks(int[] sticks) {
        // min heap
        PriorityQueue<int,int> pq = new();
        
        foreach(int stick in sticks)
            pq.Enqueue(stick, stick);
        
        int minCost = 0;
        while(pq.Count > 1) { // process till we have 1 stick left
            int stick1 = pq.Dequeue();
            int stick2 = pq.Dequeue();
            
            int combinedStick = stick1 + stick2;
            
            minCost += combinedStick;
            
            pq.Enqueue(combinedStick, combinedStick);
        }
        
        return minCost;
        
    }
}