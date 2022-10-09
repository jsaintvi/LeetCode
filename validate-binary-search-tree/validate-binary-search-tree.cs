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
        // inorder traversal
        Stack<TreeNode> st = new();
        TreeNode prev = null;
        
        while(st.Count > 0 || root != null) {
            // dig as far left
            while(root != null) {
                st.Push(root);
                root = root.left;
            }
            
            root = st.Pop();
            
            if(prev != null && root.val <= prev.val) {
                return false;
            }
            
            prev = root;
            
            // go right once
            root = root.right;
                
        }
        
        return true;
    }
}