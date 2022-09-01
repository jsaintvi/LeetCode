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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        // build index map
        index_map = BuildInorderMap(inorder);
        
        int postIndex = postorder.Length-1;
        return Helper(inorder, postorder, 0, inorder.Length -1, ref postIndex);
    }
    
    private Dictionary<int,int> BuildInorderMap(int[] inorder) {
        Dictionary<int, int> map = new();
        for(int i = 0; i < inorder.Length; i++)
            map.Add(inorder[i], i);
        
        return map;
    }
    
    private TreeNode Helper(int[]inorder, int[] postorder, int leftIndex, int rightIndex, ref int posIndex) {
        if(leftIndex > rightIndex) // subtree is empty
            return null;
        
        int rootVal = postorder[posIndex];
        
        TreeNode root = new TreeNode(rootVal);
        
        // root splits inorder list into left and right subtrees
        int index = index_map[rootVal];
        
        posIndex--;
        
        // build right subtree
        root.right = Helper(inorder, postorder, index + 1, rightIndex, ref posIndex);
        // build left subtree
        root.left = Helper(inorder, postorder, leftIndex, index-1, ref posIndex);
        
        return root;
    }
}