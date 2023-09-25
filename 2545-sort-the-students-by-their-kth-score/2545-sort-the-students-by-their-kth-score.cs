public class Solution {
    public int[][] SortTheStudents(int[][] score, int k) {
       int m = score.Length, n = score[0].Length;
        
        var pq = new PriorityQueue<RowInfo, RowInfo>(new RowInfoComparer());
        
        for(int i=0; i<m; i++){
            int s = score[i][k];
            var rowInfo = new RowInfo(s, i);
            pq.Enqueue(rowInfo, rowInfo);            
        }
        
        int[][] newScore = new int[m][];
        for(int i = 0; i < m; i++)
            newScore[i] = new int[n];
        
        int idx = 0;
        
        while(pq.Count > 0){
            var rem = pq.Dequeue();
            int row = rem.Index;
            
            newScore[idx++] = score[row];
        }
        
        
        return newScore;
    }
    
    public class RowInfoComparer : IComparer<RowInfo>
    {
        public int Compare(RowInfo x, RowInfo y)
        {

            return y.Val - x.Val;
        }
    }
    
    public class RowInfo
    {
        public int Index{get;}
        public int Val {get;}
        
        public RowInfo(int val, int idx)
        {
            this.Val = val;
            this.Index = idx;
        }
    }
}