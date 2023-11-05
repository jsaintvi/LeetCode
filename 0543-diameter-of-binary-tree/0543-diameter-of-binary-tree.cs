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
    public int DiameterOfBinaryTree(TreeNode root) {
        int[] diameter = new int[1];
        
        TreeHeight(root, diameter);
        return diameter[0];
    }
    
    private int TreeHeight(TreeNode node, int[] ans) {
        if(node == null) {
            return 0;
        }
        
        int leftHeight = TreeHeight(node.left, ans);
        int rightHeight = TreeHeight(node.right, ans);
        
        // Update the diameter array by taking the maximum diameter that passes through the current node
        ans[0] = Math.Max(ans[0], leftHeight + rightHeight);
        
        // Return the max depth of the current node by adding 1 to the maximum depth of its deepest subtree
        return 1 + Math.Max(leftHeight, rightHeight); 
    }
}