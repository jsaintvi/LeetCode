public class ProductOfNumbers {

    List<int> list;
     
    public ProductOfNumbers() {
        list = new List<int>();
    }
    
    public void Add(int num) {
         if(num==0){
             list.Clear();
         }else{
             if(list.Count==0){
                 list.Add(num);
             }else{ 
                 var a = list[list.Count-1]*num;
                 list.Add(a);
             }
         }
        
    }

    public int GetProduct(int k) {
         int index = list.Count-k;
        if(index<0){
            return 0;
        }
        else if(index==0){
            return list[list.Count-1];
        }else{
            return list[list.Count-1]/list[index-1];
        }
    }
}

/**
 * Your ProductOfNumbers object will be instantiated and called as such:
 * ProductOfNumbers obj = new ProductOfNumbers();
 * obj.Add(num);
 * int param_2 = obj.GetProduct(k);
 */