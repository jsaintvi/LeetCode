public class ProductOfNumbers {

    List<int> lst;
    int product = 1;
    public ProductOfNumbers() {
        lst = new();
    }
    
    public void Add(int num) {
        lst.Add(num);
    }
    
    public int GetProduct(int k) {
        int prod = 1;
        
        int pos = lst.Count - 1;
        
        int count = 1;
        while(count <= k) {
            prod *= lst[pos];
            
            pos--;
            count++;
        }
        
        return prod;
    }
}

/**
 * Your ProductOfNumbers object will be instantiated and called as such:
 * ProductOfNumbers obj = new ProductOfNumbers();
 * obj.Add(num);
 * int param_2 = obj.GetProduct(k);
 */