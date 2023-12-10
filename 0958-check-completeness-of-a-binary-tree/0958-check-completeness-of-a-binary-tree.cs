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
    public bool IsCompleteTree(TreeNode root) {
        if (root == null) {
            return true;
        }
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        bool flag = false;
        
        while (queue.Count > 0) {
            TreeNode current = queue.Dequeue();
            
            if (flag && current != null) {
                return false;
            }
            
            if (current == null) {
                flag = true;
            } else {
                queue.Enqueue(current.left);
                queue.Enqueue(current.right);
            }
        }
        
        return true;
    }
}