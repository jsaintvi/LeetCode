public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;
        
        int left = 0;
        int right = height.Length -1;
        
        while(left < right) {
            int currArea = Math.Min(height[left], height[right]) * (right - left); // width * height
            
            maxArea = Math.Max(maxArea, currArea);
            
            if(height[left] < height[right])
            {
                left++;
            } else{
                right--;
            }
        }
        return maxArea;
    }
}