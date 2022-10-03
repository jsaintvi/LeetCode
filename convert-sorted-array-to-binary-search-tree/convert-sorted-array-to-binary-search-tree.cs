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
    
    public TreeNode SortedArrayToBST(int[] nums) {
        int n = nums.Length;
        return Helper(nums, 0, n - 1);
    }
    
    private TreeNode Helper( int[] nums, int left, int right){
        if(left > right) return null;
        
        int p = (left + right) / 2;
        
        TreeNode root = new TreeNode(nums[p]);
        root.left = Helper(nums, left, p-1);
        root.right = Helper(nums, p+1, right);
        
        return root;
    }
}