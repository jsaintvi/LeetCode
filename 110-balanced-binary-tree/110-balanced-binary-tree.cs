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
    public bool IsBalanced(TreeNode root) {

        return GetHeight(root) != -1;
    }
    
    
    // bottom up 
    private int GetHeight(TreeNode node){
        if(node == null) return 0;
        
        int left = GetHeight(node.left);
        int right = GetHeight(node.right);
        
        var heightDiff = Math.Abs(left - right);
        if(heightDiff > 1 || left == -1 || right == -1) return -1;
        
        return Math.Max(left, right) + 1;
    }
}