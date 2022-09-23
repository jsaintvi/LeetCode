public class Solution {
    private class Point {
        public int X {get;}
        public int Y {get;}
        public int Index {get;}
      
        public Point(int x, int y, int index){
            this.X = x;
            this.Y = y;
            this.Index = index;
        }
        
        public  int DistSquared() {
            return (X * X) + (Y * Y);
        }  
    }
    public int[][] KClosest(int[][] points, int k) {
        int n = points.Length;
        
        // max heap
        PriorityQueue<Point, Point> pq = new PriorityQueue<Point,Point> (new ClosestPointComparer(k));
        
        for(int i = 0; i < n; i++) {
            var point = new Point(points[i][0], points[i][1], i);
            if(pq.Count == 0) {
                pq.Enqueue(point, point);
            }else{
                pq.Enqueue(point, point);
                if(pq.Count > k) pq.Dequeue();                
            }
        }
        
        // max queue
        
        var ans = new int[pq.Count][];
        int pos = pq.Count-1;
        while(pq.Count > 0) {
            var top = pq.Dequeue();
 
            //Console.WriteLine($"Top elem: ({top.X},{top.Y})");
            ans[pos--] = new int[2]{top.X, top.Y};
        }
        
        return ans;
    }
    
    private class ClosestPointComparer : IComparer<Point> {
        private readonly int targetPoint;
        public ClosestPointComparer(int targetPoint) {
            this.targetPoint = targetPoint;
        }
        
        public int Compare(Point p1, Point p2) {
            
            int dist2 = Math.Abs(p2.DistSquared()-targetPoint);
            int dist1 = Math.Abs(p1.DistSquared()-targetPoint);
            
            if(dist1 == dist2) return p2.Index - p1.Index;
            return dist2 - dist1;
        }
    }
}