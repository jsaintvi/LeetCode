public class Solution {
    public int KthSmallest(int[][] matrix, int k) {
        // Time Complexity: O(NLogK)
        // Space Complexity: O(K)
        
        // max heap
        PriorityQueue<int,int> pq = new(new ValComparer());
        
        int n = matrix.Length;
        
        for(int row = 0; row < n; row++) {
            for(int col = 0; col < n; col++) {
                int currCellValue = matrix[row][col];
                pq.Enqueue(currCellValue, currCellValue);
                
                // maintain at most k smallest elems in queue
                if(pq.Count > k) pq.Dequeue();
            }
        }
        
        return pq.Peek();
    }
    
    private class ValComparer : IComparer<int> {
        public int Compare(int x, int y) {
            return y-x;
        }
    }
}

