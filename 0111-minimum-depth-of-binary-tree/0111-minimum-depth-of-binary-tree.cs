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
    private class TreeNodeWithDepth {
        public TreeNode Node {get;}
        public int Depth {get;}
        
        public TreeNodeWithDepth(TreeNode node, int depth) {
            this.Node = node;
            this.Depth = depth;
        }
    }
    
    public int MinDepth(TreeNode root) {
        if(root == null)
            return 0;
        
        Queue<TreeNodeWithDepth> q = new();
        q.Enqueue(new TreeNodeWithDepth(root, 1));
        
        while(q.Count > 0) {
            var currNode = q.Peek().Node;
            var depth = q.Peek().Depth;   
            q.Dequeue();
            
            if(currNode.left == null && currNode.right == null) { // leaf node
                return depth;
            } else{
               if(currNode.left != null)
                    q.Enqueue(new TreeNodeWithDepth(currNode.left,depth + 1));

                if(currNode.right != null)
                    q.Enqueue(new TreeNodeWithDepth(currNode.right,depth + 1)); 
            }
        }
        
        return 0;
    }
}