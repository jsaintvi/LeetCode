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
public class BSTIterator {
    private TreeNode trav;
    private Stack<TreeNode> st;
    public BSTIterator(TreeNode root) {
        st = new ();
        st.Push(root);
        this.trav = root;
    }
    
    public int Next() {
        // Dig left
        while (trav != null && trav.left != null) {
          st.Push(trav.left);
          trav = trav.left;
        }
        
        var node = st.Pop();
        
        // Try moving down right once
        if (node.right != null) {
          st.Push(node.right);
          trav = node.right;
        }
        
        return node.val;
    }
    
    public bool HasNext() {
        return trav != null && st.Count> 0;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */