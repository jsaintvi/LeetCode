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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        if(root == null) { // leaf
            root = new TreeNode(val);
        }else if(val < root.val) {
            root.left = InsertIntoBST(root.left, val);
        }else{
            root.right = InsertIntoBST(root.right, val);
        }
        
        return root;
    }
}