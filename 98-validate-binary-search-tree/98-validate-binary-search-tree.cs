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
        if(root == null || (root.left == null && root.right == null) )
            return true;
        
        HashSet<int> seen = new();
        return IsValidBST(root, null, null, seen);
    }
    
    private bool IsValidBST(TreeNode root,  int? min, int? max, HashSet<int> seen) {
        if(root == null)
            return true;
        
        if(seen.Contains(root.val)) {Console.WriteLine($"Seen num {root.val}"); return false;}
        if((min.HasValue && root.val <= min.Value) || (max.HasValue && root.val >= max.Value) ){
            Console.WriteLine($"Failed check for {min} < {root.val} < {max}");
            return false;

        }
        
        seen.Add(root.val);

        return IsValidBST(root.left, min, root.val, seen) && IsValidBST(root.right, root.val, max, seen);
    }
}