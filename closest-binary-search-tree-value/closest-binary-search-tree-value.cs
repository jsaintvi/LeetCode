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
}