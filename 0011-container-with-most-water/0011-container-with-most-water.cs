public class Solution {
    public int MaxArea(int[] height) {
        
        int len = height.Length;
        

        if(len == 2){
            return Math.Min(height[0] , height[1]);
        }
        
        int max_area_so_far = -1;
        int i = 0;
        int j = len - 1;
        
        while(i < j)
        {
            int current_max = 0;
            if(height[i] < height[j])
            {
                current_max = height[i] * (j-i); 
                i++;
            } else {
                current_max = height[j] * (j-i);
                j--;
            }
            
            // update max so far if found bigger max
            if(max_area_so_far < current_max)
                max_area_so_far = current_max;
        }
        
        return max_area_so_far;
    }
}