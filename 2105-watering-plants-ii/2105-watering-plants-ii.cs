public class Solution {
    public int MinimumRefill(int[] plants, int capacityA, int capacityB) {
        int left = 0;
        int right = plants.Length - 1;
        
        int aliceCapacity = capacityA;
        int bobCapacity = capacityB;
        
        int refills = 0;
        while(left <= right) {
            if(left == right) { // reach same plant: ecide if alice gets to water that plant or bob
                
                if(aliceCapacity >= bobCapacity) {
                  WaterAndRefillIfNeeded(plants[left], capacityA, ref aliceCapacity, ref  refills);
                } else{
                  WaterAndRefillIfNeeded(plants[right], capacityB, ref bobCapacity, ref  refills);  
                }
                
            } else {
                
                // Alice watering
                WaterAndRefillIfNeeded(plants[left], capacityA, ref aliceCapacity, ref  refills);
                
                // Bob watering
                WaterAndRefillIfNeeded(plants[right], capacityB, ref bobCapacity, ref  refills);
            }
            
            // Console.WriteLine($"AFTER WATERING {left}, {right}, CapacityA: {aliceCapacity} - CapacityB {bobCapacity}");
            left++;
            right--;
        }
        
        return refills;
    }
    
    private void WaterAndRefillIfNeeded(int plantNeeds, int CanCapacity, ref int currCapacity, ref int refillCount) {
        if(currCapacity < plantNeeds) { // refill
            currCapacity = CanCapacity;
            refillCount +=1;
        }
        
        currCapacity-= plantNeeds;
        
    }
}