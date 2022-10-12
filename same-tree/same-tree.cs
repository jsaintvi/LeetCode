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
    public bool IsSameTree2(TreeNode p, TreeNode q) {
        if(p == null && q == null) return true;
        
        if(p == null || q == null) return false;
        
        if(p.val != q.val) return false;
        
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
    
    private bool IsEqual(TreeNode p, TreeNode q) {
        if(p == null && q == null) return true;
        if(p == null || q == null) return false;
        if(p.val != q.val) return false;
        
        return true;
    }
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p== null && q == null) return true;
        if(!IsEqual(p, q)) return false;
        
        Queue<TreeNode> q1 = new Queue<TreeNode>();
        q1.Enqueue(p);
        Queue<TreeNode> q2 = new Queue<TreeNode>();
        q2.Enqueue(q);
        
        while(q1.Count > 0 && q2.Count > 0) {
                TreeNode curr1 = q1.Dequeue();
                TreeNode curr2 = q2.Dequeue();
                if(!IsEqual(curr1, curr2))
                    return false;
                
                if(!IsEqual(curr1.left, curr2.left)) return false;
                if(!IsEqual(curr1.right, curr2.right)) return false;

                if(curr1.left!= null)
                    q1.Enqueue(curr1.left);
                
                if(curr1.right != null)
                    q1.Enqueue(curr1.right);
                
                if(curr2.left != null)
                    q2.Enqueue(curr2.left);
                    
                if(curr2.right != null)
                    q2.Enqueue(curr2.right);
        }
        
        return q1.Count == 0 && q2.Count ==0;

    }
}