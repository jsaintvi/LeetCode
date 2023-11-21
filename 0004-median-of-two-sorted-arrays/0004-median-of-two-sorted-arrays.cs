public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var mf = new MedianFinder();
        foreach(var x in nums1)
            mf.AddNum(x);
        
        foreach(var y in nums2)
            mf.AddNum(y);
        
        return mf.FindMedian();
    }
    
    public class MedianFinder {
        private PriorityQueue<int, int> small;
        private PriorityQueue<int,int> large;

        public MedianFinder() {
            small = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            large = new PriorityQueue<int,int>(Comparer<int>.Create((x, y) => x.CompareTo(y)));
        }

        public void AddNum(int num) {
            small.Enqueue(num, num);
            var el = small.Dequeue();
            large.Enqueue(el,el);

            if (small.Count < large.Count) {
                var l = large.Dequeue();
                small.Enqueue(l,l);
            }
        }

        public double FindMedian() {
            if (small.Count > large.Count) {
                return small.Peek();
            } else {
                return (small.Peek() + large.Peek()) / 2.0;
            }
        }
    }
}