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
    public TreeNode SearchBST(TreeNode root, int val) {
        
        TreeNode curr = root;
        while(curr != null) {
            if(curr.val == val)
                return curr;
            
            if(val < curr.val) {
                curr = curr.left;
            } else {
                curr = curr.right;
            } 
        }

        
        // if we make it here, val not in tree
        return null;
    }
}