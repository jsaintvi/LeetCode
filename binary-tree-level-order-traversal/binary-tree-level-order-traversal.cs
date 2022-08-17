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
    public IList<IList<int>> LevelOrder(TreeNode root) {
           // base case
            if (root == null) return new List<IList<int>>();
            
            IList<IList<int>> ans = new List<IList<int>>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            
            // traverse while queue not empty
            while (q.Count > 0)
            {
                // curr level
                int currLevelNodeCount = q.Count;
                
                List<int> curLevelNodeData = new List<int>();
                // traverse curr level nodes and add them to list
                for(int i = 0; i < currLevelNodeCount; i++)
                {
                    TreeNode currNode = q.Dequeue();
                    curLevelNodeData.Add(currNode.val);
                    
                    if(currNode.left != null)
                        q.Enqueue(currNode.left);

                    if(currNode.right != null)
                        q.Enqueue(currNode.right);                    
                }
                
                ans.Add(curLevelNodeData);
            }

            return ans;
    }
}