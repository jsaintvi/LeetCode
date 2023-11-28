public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int totalWeight = Sum(weights);
        int left = FindMax(weights);
        int right = totalWeight;
        
        while(left < right) {
            int mid = left + (right - left) / 2; // current shipment capacity being tested
            int weightedSum = 0; // total weight of packages that have been shipped in the current day
            int shipDays = 1; // total number of days needed to ship all packages
            
            // check if mid is valid shipment capacity
            foreach(var weight in weights) {
                if(weightedSum + weight > mid) {
                    weightedSum = weight;
                    shipDays +=1;
                } else{
                    weightedSum+= weight;
                }
            }
            
            if(shipDays <= days) {
                right = mid;
            } else{
                left = mid + 1;
            }
        }
        
        return left;
    }
    
    private int Sum(int[] arr) {
        int sum = 0;
        
        foreach(var el in arr)
            sum += el;
        
        return sum;
    }
    
    private int FindMax(int[] arr) {
        int max = 0;
        
        foreach(var el in arr)
            max = Math.Max(max, el);
        
        return max;
    }
}