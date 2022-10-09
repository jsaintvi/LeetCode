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
    public bool IsValidBST(TreeNode root) {
        
        return IsValidBST(root, null, null);
    }
    
    private bool IsValidBST(TreeNode root, TreeNode low, TreeNode upper) {
        if(root == null)
            return true;
        
        if( (low != null && root.val <= low.val) || (upper != null && root.val >= upper.val) )
            return false;;
        
        return IsValidBST(root.left, low, root) && IsValidBST(root.right, root, upper);
    }
}