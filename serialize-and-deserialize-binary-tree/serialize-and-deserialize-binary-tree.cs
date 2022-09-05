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
        StringBuilder sb = new();

        Serialize_Impl(root, sb);
       // Console.WriteLine(sb.ToString());
        return sb.ToString();
    }
    


    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        string[] content = data.Split(",");
        
        return deserialize_Impl(new LinkedList<string>(content));
    }
    
    // pre order trav
    private void Serialize_Impl(TreeNode node, StringBuilder sb) {
        
        if(node == null){
            sb.Append("null,");
        }
        else{
            sb.Append(node.val);
            sb.Append(",");
            Serialize_Impl(node.left, sb);
            Serialize_Impl(node.right, sb);
        }
    }
    
    private TreeNode deserialize_Impl(LinkedList<string> ll) {
        if(ll.First.Value == "null") {
            ll.RemoveFirst();
            return null;
        }
        
        TreeNode root = new TreeNode(int.Parse(ll.First.Value));
        ll.RemoveFirst();
        
        root.left = deserialize_Impl(ll);
        root.right = deserialize_Impl(ll);
        
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));