public class Solution {
    public int Fib(int n) {
        var cache = new Dictionary<int,int>();
        
        return Fib(n, cache);
    }
    
    private int Fib(int n , Dictionary<int,int> cache){
        if(cache.ContainsKey(n))
            return cache[n];
        
        int result;
        
        if(n < 2)
            result = n;
        else
            result = Fib(n-1, cache) + Fib(n-2, cache);
        
        return result;
    }
}