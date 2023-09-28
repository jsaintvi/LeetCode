public class Solution {
    public bool CarPooling(int[][] trips, int capacity) {
        SortedDictionary<int, int> tripMap = new(); //key: from/to, Value: numPassengers at that point
        
        for(int i = 0; i < trips.Length; i++)
        {
            int[] currTrip = trips[i];
            int from = currTrip[1];
            int to = currTrip[2];
            int numPassengers = currTrip[0];
            
            if(!tripMap.ContainsKey(from)) tripMap.Add(from, 0);
            if(!tripMap.ContainsKey(to)) tripMap.Add(to,0);
            
            tripMap[from]+= numPassengers;
            tripMap[to] -= numPassengers;
        }
        
        PrintDict(tripMap);
        
        int curr = 0;
        foreach(var kv in tripMap)
        {
            curr += kv.Value;
            
            if(curr > capacity) 
                return false;
        }
        
        return true;
    }
    
    private void PrintDict(SortedDictionary<int,int> map)
    {
        Console.WriteLine("----------------PRINTING MAP-------------------");
        foreach(var kv in map)
        {
            Console.WriteLine($"Location {kv.Key} with {kv.Value} passengers");
        }
        Console.WriteLine("-------------------END-------------------------");
    }
}