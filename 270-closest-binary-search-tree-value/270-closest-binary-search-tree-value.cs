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
//         List<int> values = new();
//         InOrder(root, (x) => values.Add(x));
        
//         var comp = new ClosestIntComparer(target);
//         values.Sort(comp);
        
//         return values.First();
        
        int closest = root.val;
        
        while(root != null) {
            if(Math.Abs(root.val - target) < Math.Abs(closest - target)) { // found closer val than previously known
                closest = root.val;
            }
            
            root = target < root.val ? root.left : root.right;
        }
        
        return closest;

    }
    
    private int ClosestValueV2(TreeNode root, double target) {
                Stack<TreeNode> stack = new ();
        
        int pred = int.MinValue;
        
        while(stack.Count > 0 || root != null) {
            while(root != null) {
                stack.Push(root);
                root = root.left;
            }
            
            root = stack.Pop();
            
            if(pred <= target && target < root.val) {
                return Math.Abs(pred-target) < Math.Abs(root.val - target) ? pred : root.val;
            }
            
            pred = root.val;
            root = root.right;
        }
        
        return pred;
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