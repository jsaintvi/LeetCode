public class Solution {
    public int FindSpecialInteger(int[] arr) {
        Dictionary<int, int> map = new();
        
        int len = arr.Length;
        foreach(var num in arr) {
            if(!map.ContainsKey(num))
                map.Add(num, 0);
            
            map[num]++;
        }
        
        foreach(var kv in map)
        {
            Console.WriteLine($"Key: {kv.Key} - Val : {kv.Value}. Ratio: {kv.Value / (len * 1.0)}");
            if(kv.Value  / (len * 1.0) > 0.25)
                return kv.Key;
        }
        
        return -1;
    }
}