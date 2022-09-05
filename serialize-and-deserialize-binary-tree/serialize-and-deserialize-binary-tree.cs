/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if(root == null) return string.Empty;
        
        StringBuilder sb = new();

        Queue<TreeNode> q = new();
        q.Enqueue(root);
        while(q.Count > 0) {
            var node = q.Dequeue();
            
            if(node == null){
                sb.Append("null,");
                continue;
            }
            
            sb.Append(node.val);
            sb.Append(",");
            q.Enqueue(node.left);
            q.Enqueue(node.right);
        }
        
        return sb.ToString();
    }
    


    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if(string.IsNullOrEmpty(data)) return null;
        string[] content = data.Split(",");
        
        int contentLen = content.Length;
        var firstVal = content[0];
        
        TreeNode root = new(Convert.ToInt32(firstVal));
        Queue<TreeNode> q = new();
        q.Enqueue(root);
        
        int pos = 1; // starting at 1 cause we already enqueued first val
        while(q.Count > 0 && pos <  contentLen) {
            var node = q.Dequeue();
            
            if(content[pos]!= "null")
            {
                var left = new TreeNode(Convert.ToInt32(content[pos]));
                node.left = left;
                q.Enqueue(left);
            }
            pos++;
                                        
            if(content[pos] != "null") {
                var right = new TreeNode(Convert.ToInt32(content[pos]));
                node.right = right;
                q.Enqueue(right);
            }
            pos++;
            
        }
        
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));