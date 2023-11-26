public class Solution {
    private class PowerInfo{
        public int Num {get;set;}
        public int Power {get;set;}
        
        public PowerInfo(int num, int pow)
        {
            this.Num = num;
            this.Power = pow;
        }
    }
    
    public int GetKth(int lo, int hi, int k) {
        PriorityQueue<int, PowerInfo> pq = new(new PowerComparer());
        
       for(int i=lo; i<=hi; i++){
            int p = CalcPower(i) ;
           Console.WriteLine($"Power of {i} is {p}");
           pq.Enqueue(i, new PowerInfo(i, p));
        } 
        
        while(k-1 > 0)
        {
            var el = pq.Dequeue();
            k--;
        }
        
        return pq.Peek();
    }
    
    private int CalcPower(int n){
        int power = 0 ;
        while(n != 1){
            if(n % 2 == 0){
                n = n / 2 ;
                power++ ;
            }
            else{
                n = 3 * n + 1 ;
                power++ ;
            }
        }
        return power ;
    }
    
    private class PowerComparer : IComparer<PowerInfo>
    {
        public int Compare(PowerInfo p1, PowerInfo p2) {
            if(p1.Power == p2.Power)
                return p1.Num - p2.Num;
            
            return p1.Power - p2.Power;
        }
    }
}