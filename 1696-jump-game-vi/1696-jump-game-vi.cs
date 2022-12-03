public class Solution {
    public int MaxResult(int[] nums, int k) {
        int n = nums.Length;
        int[] score = new int[n];
        score[0] = nums[0];
        PriorityQueue<int,int> pq = new (new ScoreComparer());
        pq.Enqueue(0, nums[0]);
        
        for(int i = 1; i < n; i++) {
            while(pq.Peek() < i - k) { // factor in ONLY elemets from [i-k ... i-1]
                pq.Dequeue();
            }
            
            score[i] = nums[i] + score[pq.Peek()];
            pq.Enqueue(i, score[i]);
        }
        
        return score[n-1];
    }
    
    private class ScoreComparer : IComparer<int> {
        public int Compare(int x , int y) {
            return y-x;
        }
    }
}