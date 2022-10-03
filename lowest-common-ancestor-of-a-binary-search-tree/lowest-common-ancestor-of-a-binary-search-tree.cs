/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        int parentVal = root.val;
        
        int pVal = p.val;
        int qVal = q.val;
        
        if(pVal > parentVal && qVal > parentVal) {
            // search in right subtree
            return LowestCommonAncestor(root.right, p, q);
        }else if(pVal < parentVal && qVal < parentVal) {
            // search in left subtree
            return LowestCommonAncestor(root.left, p, q);
        }else{
            return root;
        }
    }
}