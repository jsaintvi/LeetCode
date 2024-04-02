public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        List<IList<int>> ans = new();
        
        ans.Add(new List<int> {1});
        
        if(numRows == 1)
        {
            return ans;
        }
        
        ans.Add(new List<int> {1,1});

        for(int i = 2; i < numRows; i++)
        {
            var curr = new List<int>();
            curr.Add(1);

            var lastRow = ans.Last();
            //PrintLst(lastRow);
            int j = 0; 
            int k = 1;

            while(k < lastRow.Count())
            {
                curr.Add(lastRow[j] + lastRow[k]);

                j++;
                k++;
            }

            curr.Add(1);

            ans.Add(curr);
        }
        
        
        return ans;
    }
    
    void PrintLst(IList<int> lst)
    {
        Console.WriteLine("---------PRINTING-----------");
        foreach(var num in lst)
        {
            Console.Write($"{num}--");
        }
        
        Console.WriteLine("------------END-------------");
    }
}