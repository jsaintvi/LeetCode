/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;

    public Node() {}

    public Node(int _val) {
        val = _val;
        left = null;
        right = null;
    }

    public Node(int _val,Node _left,Node _right) {
        val = _val;
        left = _left;
        right = _right;
    }
}
*/

public class Solution {
            
    Node first = null;
    Node last = null;
    public Node TreeToDoublyList(Node root) {
        if(root == null) return null;

        
        DFS(root);
        
        last.right = first;
        first.left = last;
        
        return first;
        
    }
    
    private void DFS(Node root) {
        if(root == null) return;
        
        DFS(root.left);
        
        if(last != null) {
            // link prev node (last) with curr node (root)
            last.right = root;
            
            root.left = last;
        }else {
            // keep the smallest node 
            first = root;
        }
        
        last = root;
        
        // right
        DFS(root.right);
    }
}