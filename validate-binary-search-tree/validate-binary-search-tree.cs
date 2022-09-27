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
        if(root == null)
            return true;
        
        List<int> nodeValues = new();
        InOrder(root, (x)=> nodeValues.Add(x));
        
        int n = nodeValues.Count;
        for(int i = 0; i < n - 1; i++){
            if(nodeValues[i] >= nodeValues[i+1]) return false;
        }
        return true;
    }
    
    private void InOrder(TreeNode root, Action<int> process)
    {
        if(root==null)
            return;
        InOrder(root.left, process);
        process(root.val);
        InOrder(root.right, process);
    }
}