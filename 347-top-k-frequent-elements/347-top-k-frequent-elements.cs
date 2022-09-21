public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        if(k == nums.Length)
            return nums;
        
        Dictionary<int,int> map = new();
        
        foreach(int num in nums)
        {
            if(!map.ContainsKey(num)) map.Add(num, 0);
            
            map[num]++;
        }
        // min heap with k elems
        PriorityQueue<int,int> pq = new PriorityQueue<int,int> (k, new HeapElemComparer(map));
        foreach(var kv in map) {
            pq.Enqueue(kv.Key, kv.Key);
            
            if(pq.Count > k) pq.Dequeue();
        }
        
        Console.WriteLine(pq.Count);
        List<int> res = new List<int>(k);
        while(pq.Count  > 0)
            res.Add(pq.Dequeue());
        return res.ToArray();
    }
    
    private class HeapElemComparer : IComparer<int> {
        private readonly Dictionary<int,int> Map = new ();
        public HeapElemComparer(Dictionary<int,int> map) {
            this.Map = map;
        }
        public int Compare(int x, int y) {
            return Map[x] - Map[y];
        }
    }
}