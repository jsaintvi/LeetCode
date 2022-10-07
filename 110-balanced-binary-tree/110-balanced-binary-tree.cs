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
        if (root == null) return true;
        
        bool isBalanced = true;
        Dfs(root, ref isBalanced);
       // Console.WriteLine($"Height of tree {height}");
        return isBalanced;
    }
    
    private int Dfs(TreeNode node, ref bool isBalanced) {
        if (node == null)
            return 0;
        
        int leftHeight = Dfs(node.left, ref isBalanced);
        int rightHeight = Dfs(node.right, ref isBalanced);
        
        if (Math.Abs(leftHeight - rightHeight) > 1)
        {
            isBalanced = false;
        }
        
        return Math.Max(leftHeight, rightHeight) + 1;
    }
}