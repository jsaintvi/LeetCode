public class Solution {
    public bool CarPooling(int[][] trips, int capacity) {
        int[] tripMap = new int[1001]; //key: from/to, Value: numPassengers at that point
        
        for(int i = 0; i < trips.Length; i++)
        {
            int[] currTrip = trips[i];
            int from = currTrip[1];
            int to = currTrip[2];
            int numPassengers = currTrip[0];

            tripMap[from]+= numPassengers;
            tripMap[to] -= numPassengers;
        }
        
        
        int curr = 0;
        for(int i = 0; i < tripMap.Length; i++)
        {
            curr+= tripMap[i];
            if(curr > capacity) 
                return false;
        }
        
        return true;
    }
}