/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode InorderSuccessor(TreeNode root, TreeNode p) {
        
        List<int> data = new();
        InOrder(root, (x)=> data.Add(x));
        
        int n = data.Count;
        for(int i = 0; i < n -1; i++) {
            if(data[i] == p.val){
                return new TreeNode(data[i+1]);
            }
        }
        
        return null;
    }
    
    private void InOrder(TreeNode node, Action<int> process){
        if(node == null) return;
        InOrder(node.left, process);
        process(node.val);
        InOrder(node.right, process); 
    }
}