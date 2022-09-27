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
    public TreeNode DeleteNode(TreeNode root, int key) {
        return Remove(root, key);
    }
    
    private TreeNode Remove(TreeNode node, int val){
        if(node == null) return null;
        
        if(val < node.val) {
            node.left = Remove(node.left, val);
        }else if(val > node.val) {
            node.right = Remove(node.right, val);
        }else{ // found node we want to remove
            
            if(node.left == null){
                return node.right;
            }else if(node.right == null) {
                return node.left;
            } else {
                // Find the leftmost node in the right subtree
                var tmp = FindMin(node.right);
                
                // copy 'newfound' val in node we wish to remove then delete that node
                node.val = tmp.val;
                node.right = Remove(node.right, tmp.val);
            }
        }
        
        return node;
    }
    
    // find smallest value
    private TreeNode FindMin(TreeNode node){
        while(node.left != null) node = node.left;
        
        return node;
    }
}