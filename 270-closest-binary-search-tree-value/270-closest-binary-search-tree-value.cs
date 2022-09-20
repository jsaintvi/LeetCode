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
    public int ClosestValue(TreeNode root, double target) {
        List<int> values = new();
        InOrder(root, (x) => values.Add(x));
        
        var comp = new ClosestIntComparer(target);
        values.Sort(comp);
        
        return values.First();
    }
    
    private void InOrder(TreeNode node, Action<int> action) {
        if(node==null) return;
        
        InOrder(node.left, action);
        action(node.val);
        InOrder(node.right, action);
    }
    
    private class ClosestIntComparer : IComparer<int> {
        private readonly double Target;
        public ClosestIntComparer(double target) {
            this.Target = target;
        }
        public int Compare(int x, int y) {
            return Math.Abs(x - Target) < Math.Abs(y - Target) ? -1 : 1;
        }
    }
}