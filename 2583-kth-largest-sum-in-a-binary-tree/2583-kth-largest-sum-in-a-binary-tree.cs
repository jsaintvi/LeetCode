/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public long KthLargestLevelSum(TreeNode root, int k) {
        if(root == null)
            return -1;
        
        PriorityQueue<long,long> pq = new();
        
        Queue<TreeNode> q = new();
        q.Enqueue(root);
        
        int levelCount = 0;
        while(q.Count > 0) {
            int currLevelCount = q.Count;
            
            long levelSum = 0;
            for(int i = 1; i <= currLevelCount; i++) {
                TreeNode node = q.Dequeue();
                levelSum += node.val;
                
                if(node.left != null) q.Enqueue(node.left);
                if(node.right != null) q.Enqueue(node.right);
            }
            
            pq.Enqueue(levelSum, levelSum);
            if(pq.Count > k)
                pq.Dequeue();
            
            levelCount +=1;
        }
        
        if(levelCount <k) return -1;
        
        return pq.Peek();
    }
}