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
    public bool HasPathSum(TreeNode root, int targetSum) {
        if(root == null) {
            return false;
        }
        
        if(root.left == null && root.right == null) {// leaf node???
            return targetSum == root.val;
        }
        
        int remainingSum = targetSum - root.val;
        
        return HasPathSum(root.left, remainingSum) || HasPathSum(root.right, remainingSum);
    }
}