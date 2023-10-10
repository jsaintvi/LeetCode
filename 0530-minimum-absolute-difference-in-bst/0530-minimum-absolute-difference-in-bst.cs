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
    int minDiff = int.MaxValue;
    int? prev = null;
    public int GetMinimumDifference(TreeNode root) {

       if(root == null) {
           return minDiff;
       }
        
        GetMinimumDifference(root.left);
        if(prev.HasValue) {
            minDiff = Math.Min(minDiff, root.val - prev.Value);
        }
        
        prev = root.val;
        GetMinimumDifference(root.right);
        
        return minDiff;
    }
}