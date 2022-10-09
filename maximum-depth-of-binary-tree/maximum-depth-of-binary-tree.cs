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
private class Pair{
    public TreeNode Node;
    public int Depth;
    
    public Pair(TreeNode node, int depth) {
        this.Node = node;
        this.Depth = depth;
    }
}
 private int count = 0;
    public int MaxDepth(TreeNode root) {
        if(root == null) return 0;
        
        Stack<Pair> st = new();
        st.Push(new Pair(root, 1));
        
        int max_depth = 0;
        
        while(st.Count > 0) {
            var travPair = st.Pop();
            
            var travDepth = travPair.Depth;
            var travNode = travPair.Node;
            
            max_depth = Math.Max(max_depth, travDepth);
            
            if(travNode.left != null) {
                st.Push(new Pair(travNode.left, travDepth+1));
            }
            
            if(travNode.right != null) {
                st.Push(new Pair(travNode.right, travDepth+1));
            }
        }
        
        return max_depth;
    }
    

}