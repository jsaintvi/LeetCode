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
    public TreeNode InorderSuccessor(TreeNode root, TreeNode p) {
        TreeNode succ = null;
        
        while(root!=null)
        {
            if(p.val>=root.val)
                root = root.right;
            else
            {
                succ = root;
                root = root.left;
            }
        }
        return succ;
    }
}