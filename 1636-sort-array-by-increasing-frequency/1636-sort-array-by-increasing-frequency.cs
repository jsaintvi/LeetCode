public class Solution {
    private class NumInfo{
        public int Num{get;set;}
        public int Priority {get;set;}
    }
    public int[] FrequencySort(int[] nums) {
        var dict = new Dictionary<int, int>();
        
        foreach(var num in nums)
        {
            if(dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict[num] = 1;
            }
        }
        
        var priorityQueue = new PriorityQueue<int, NumInfo>(new NumComparer());
        
        foreach(var kvp in dict)
        {
            priorityQueue.Enqueue(kvp.Key, new NumInfo(){Num = kvp.Key, Priority = kvp.Value});
        }
        
        var sortedArray = new int[nums.Length];
        int pos = 0;
        
        while(priorityQueue.Count > 0)
        {
            
            priorityQueue.TryDequeue(out int num, out NumInfo frequency);
            
            for(int i = 0; i < frequency.Priority; i++)
            {
                sortedArray[pos++] = num;
            }
        }
        
        return sortedArray;
    }
    
    private class NumComparer : IComparer<NumInfo>
    {
        public int Compare(NumInfo x, NumInfo y) {
            if(x.Priority == y.Priority) {
                return y.Num.CompareTo(x.Num);
            } else{
                return x.Priority.CompareTo(y.Priority);
            }
            
            
        }
    }
}