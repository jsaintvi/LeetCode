public class Solution {
    public int FurthestBuilding(int[] heights, int bricks, int ladders) {
        PriorityQueue<int,int> pq = new();
        
        int n = heights.Length;
        
        for(int i = 0; i < n - 1; i++) {
            var currBldgHeight = heights[i];
            var nxtBldgHeight = heights[i + 1];
            
            int climb = nxtBldgHeight - currBldgHeight;
            
            if(climb <= 0) { // going down, we can skip
                continue;
            }
            
            pq.Enqueue(climb, climb);
            
            // If we haven't gone over the number of ladders, nothing else to do.
            if(pq.Count <= ladders) {
                continue;
            }
            
            bricks -= pq.Dequeue();
            
            // If this caused bricks to go negative, we can't get to i + 1            
            if(bricks < 0) {
                return i;
            }
            
        }
        
        // If we got to here, this means we had enough materials to cover every climb.
        return heights.Length - 1;

    }
}