/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null){
            return null;
        }
        
        var visited = new Dictionary<int, Node>();
        return CloneGraph(node, visited);
    }
    
    private Node CloneGraph(Node node, Dictionary<int, Node> dict)
    {
        if(dict.ContainsKey(node.val))
        {
            return dict[node.val];
        }
        
        Node copy = new Node(node.val, new List<Node>());
        // mark as visited
        dict.Add(copy.val, copy);
        
        foreach(Node neibor in node.neighbors)
        {
            copy.neighbors.Add(CloneGraph(neibor, dict));
        }
        
        return copy;
    }
}