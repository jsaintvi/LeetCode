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
    public int CountUnivalSubtrees(TreeNode root) {
        if(root == null) return 0;
        int count = 0;
        IsUni(root, ref count);
        
        return count;
    }
    
//     private bool IsUni(TreeNode node, ref int count) {
//         /*
//             2 criteria for univalue subtree"
//             1- Node has no children
//             2- All of th node children are univalues subtrees and the node and its children all have the same value
        
//         */
//         if(node.left == null && node.right == null) { // leaf nodes
//             count++;
//             return true;
//         }
        
//         bool is_uniVal = true;
        
//         if(node.left != null)
//             is_uniVal = IsUni(node.left, ref count) && is_uniVal && node.left.val == node.val;
        
//         if(node.right != null)
//             is_uniVal = IsUni(node.right, ref count) && is_uniVal && node.right.val == node.val;
        
        
//         if(!is_uniVal)
//             return false;
        
//         count++;
//         return true;
//     }
    
    public bool IsUni(TreeNode root, ref int count) {
        
        /*
            TWO criteria for univalue subtree"
            1- Node has no children
            2- All of th node children are univalues subtrees and the node and its children all have the                same value
        
        */
        
        if (root is null) return true;
        bool left = IsUni(root.left, ref count);
        bool right = IsUni(root.right, ref count);
        if (left && right && 
           (root.left == null || root.val == root.left.val) && 
           (root.right == null || root.val == root.right.val)) {
            count++;
            return true;
        }
        return false;
    }
}