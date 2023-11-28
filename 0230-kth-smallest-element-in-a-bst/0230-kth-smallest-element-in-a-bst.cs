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
    private int count;
    private int kthSmallest;
    public int KthSmallest(TreeNode root, int k) {
        count = kthSmallest = 0;
        
        DFS(root, k);
        
        return kthSmallest;
    }
    
    // Inorder traversal
    private void DFS(TreeNode node, int k) {
        if(node == null || count >= k) 
            return;
        
        DFS(node.left, k);
        
        count++;
        
        if(count == k) {
            kthSmallest = node.val;
            return;
        }
        
        DFS(node.right, k);
    }
}