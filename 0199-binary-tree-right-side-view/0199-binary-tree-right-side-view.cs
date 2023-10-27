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
    public IList<int> RightSideView(TreeNode root) {
        List<int> ans = new();
        
        if(root == null)
            return ans;
        
        Queue<TreeNode> q = new();
        q.Enqueue(root);
        
        while(q.Count > 0) {            
            var currLevelNodeCount = q.Count();
            
            for(int i = 1; i <= currLevelNodeCount; i++) {
                var currNode = q.Dequeue();
                if(i == currLevelNodeCount)
                    ans.Add(currNode.val);
                
                if(currNode.left != null)
                    q.Enqueue(currNode.left);
                
                if(currNode.right != null)
                    q.Enqueue(currNode.right);
                    
            }
        }
        
        return ans;
    }
}