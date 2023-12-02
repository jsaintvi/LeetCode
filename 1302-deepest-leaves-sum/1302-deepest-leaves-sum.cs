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
    public int DeepestLeavesSum(TreeNode root) {
        Queue<TreeNode> q = new();
        q.Enqueue(root);
        
        int sum = 0;
        
        while(q.Count > 0) {
            sum = 0;
            int currLevelNodeCount = q.Count;
            
            for(int i = 1; i <= currLevelNodeCount; i++) {
                var curr = q.Dequeue();
                
                sum += curr.val;
                
                if(curr.left != null)
                    q.Enqueue(curr.left);
                
                if(curr.right != null)
                    q.Enqueue(curr.right);
            }
        }
        
        return sum;
    }
}