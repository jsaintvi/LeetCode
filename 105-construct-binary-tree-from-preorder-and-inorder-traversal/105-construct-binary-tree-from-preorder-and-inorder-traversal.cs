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
    Dictionary<int, int> index_map = new();
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        // build index map
        index_map = BuildInorderMap(inorder);
        
        int preIndex = 0;
        return Helper(preorder, 0, inorder.Length -1, ref preIndex);
    }
    
    
    private Dictionary<int,int> BuildInorderMap(int[] inorder) {
        Dictionary<int, int> map = new();
        for(int i = 0; i < inorder.Length; i++)
            map.Add(inorder[i], i);
        
        return map;
    }
    
    private TreeNode Helper(int[] preorder, int leftIndex, int rightIndex, ref int preIndex) {
        if(leftIndex > rightIndex) // subtree is empty
            return null;
        
        int rootVal = preorder[preIndex];
        
        TreeNode root = new TreeNode(rootVal);
        
        // root splits inorder list into left and right subtrees
        int index = index_map[rootVal];
        
        preIndex++;
        
        // build left subtree
        root.left = Helper(preorder, leftIndex, index-1, ref preIndex);
        
        // build right subtree
        root.right = Helper(preorder, index + 1, rightIndex, ref preIndex);

        
        return root;
    }
}