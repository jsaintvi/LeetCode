public class Solution {
    public IList<IList<int>> Generate(int numRows) {
       IList<IList<int>> triangle = new List<IList<int>>();
        
        if (numRows == 0)
            return triangle;
        
        for (int i = 0; i < numRows; i++) {
            IList<int> currRow = new List<int>(i + 1);
            currRow.Add(1); // First element of each row is always 1
            
            // Calculate the elements in the current row based on the previous row
            for (int j = 1; j < i; j++) {
                IList<int> prevRow = triangle[i - 1];
                currRow.Add(prevRow[j - 1] + prevRow[j]);
            }
            
            if (i > 0) // Skip if it's the first row
                currRow.Add(1); // Last element of each row is always 1
            
            triangle.Add(currRow);
        }
        
        return triangle;
    }
}