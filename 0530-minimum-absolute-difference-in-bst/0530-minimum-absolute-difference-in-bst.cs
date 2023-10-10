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
    public int GetMinimumDifference(TreeNode root) {

        Stack<TreeNode> st = new();
        TreeNode curr = root;
        TreeNode prev = null;
        int minDiff = int.MaxValue;
        while(curr != null || st.Count > 0) {
            if(curr != null) {
                st.Push(curr);
                curr = curr.left;
            } else {
                curr = st.Pop();
                if(prev != null){
                    minDiff = Math.Min(minDiff, curr.val - prev.val);                    
                }
                
                prev = curr;
                curr = curr.right;
            }
        }
        
        return minDiff;
    }
}