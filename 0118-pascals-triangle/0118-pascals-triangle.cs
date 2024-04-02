public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> triangle = new List<IList<int>>();
        
        if (numRows == 0)
            return triangle;
        
        // Initialize the first row with 1
        IList<int> firstRow = new List<int>();
        firstRow.Add(1);
        triangle.Add(firstRow);
        
        for (int i = 1; i < numRows; i++) {
            IList<int> prevRow = triangle[i - 1];
            IList<int> currRow = new List<int>();
            
            // The first element of each row is always 1
            currRow.Add(1);
            
            // Calculate the elements in the current row based on the previous row
            for (int j = 1; j < i; j++) {
                currRow.Add(prevRow[j - 1] + prevRow[j]);
            }
            
            // The last element of each row is always 1
            currRow.Add(1);
            
            triangle.Add(currRow);
        }
        
        return triangle;
    }
}