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
    public int AmountOfTime(TreeNode root, int start) {
        var adjDict = GetAdjacencyDictionary(root);
        var infected = new HashSet<int>();
        var toInfect = new Queue<int>();
        var time = -1;

        toInfect.Enqueue(start);

        while (toInfect.Count > 0)
        {
            time += 1;
            var count = toInfect.Count;
            for (var i = 0; i < count; i++)
            {
                var curr = toInfect.Dequeue();
                infected.Add(curr);
                foreach (var neighbor in adjDict[curr])
                {
                    if (!infected.Contains(neighbor))
                    {
                        toInfect.Enqueue(neighbor);
                    }
                }
            }
        }

        return time;
    }
    
    private Dictionary<int, List<int>> GetAdjacencyDictionary(TreeNode root)
    {
        var adjDict = new Dictionary<int, List<int>>();
        adjDict[root.val] = new();
        TraverseDfs(root.left, root);
        TraverseDfs(root.right, root);
        return adjDict;

        void TraverseDfs(TreeNode node, TreeNode parent)
        {
            if (node != null)
            {
                adjDict[node.val] = new();
                adjDict[node.val].Add(parent.val);
                adjDict[parent.val].Add(node.val);
                TraverseDfs(node.left, node);
                TraverseDfs(node.right, node);
            }
        }
    }
}