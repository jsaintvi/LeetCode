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
        return Add(root, val);
    }
    
    private TreeNode Add(TreeNode node, int val) {
        if(node == null) { // leaf
            node = new TreeNode(val);
        }else if(val < node.val) {
            node.left = Add(node.left, val);
        }else{
            node.right = Add(node.right, val);
        }
        
        return node;
    }
}