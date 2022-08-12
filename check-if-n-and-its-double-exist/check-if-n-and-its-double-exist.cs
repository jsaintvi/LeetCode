public class Solution {
    public bool CheckIfExist(int[] arr) {
        
        HashSet<int> set = new HashSet<int>();
        
        foreach(int num in arr)
        {
            if(num % 2 == 0 && (set.Contains(num * 2) || set.Contains(num / 2)))
                return true;
            else if(num % 2 != 0 && set.Contains(num * 2))
                return true;
            
            set.Add(num);
        }
        
        return false;
    }
}