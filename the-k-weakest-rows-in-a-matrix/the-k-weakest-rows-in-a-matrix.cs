public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        Dictionary<int,int> freq = new();
        
        for(int row = 0; row < mat.Length; row++) {
            int rowSoldierCount = 0;
            for(int col = 0; col < mat[0].Length; col++) {
                if(mat[row][col] ==1)
                    rowSoldierCount++;
            }
            
            if(!freq.ContainsKey(row)) freq.Add(row, 0);
            freq[row] = rowSoldierCount;
        }
        
        // PrintDict(freq);
        
        // max heap
        PriorityQueue<int,int> pq = new(new SoldierRowStrengthComparer(freq));
        
        foreach(int val in freq.Keys) {
            pq.Enqueue(val, val);
            
            if(pq.Count > k) 
                pq.Dequeue();
        }
        
        
        int[] res = new int[pq.Count];
        int pos = res.Length -1;
        while(pq.Count > 0) {
            res[pos--] = pq.Dequeue();
        }
        
        return res;
    }
    
    private void PrintDict(Dictionary<int, int> map) {
        foreach(var kv in map) {
            Console.WriteLine($"Row: {kv.Key} with {kv.Value} soldiers");
        }
    }
    
    private class SoldierRowStrengthComparer : IComparer<int> {
        private readonly Dictionary<int,int> freq;
        public SoldierRowStrengthComparer(Dictionary<int,int> map) {
            this.freq = map;
        }
        
        public int Compare(int x, int y) {
            if(freq[y] == freq[x]) return y-x;
            
            return freq[y] - freq[x];
        }
    }
    
}