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
            
    public Node TreeToDoublyList(Node root) {
        if (root == null) {
            return null;
        }
        
        Node head = null;
        Stack<Node> stack = new Stack<Node>();
        Node cur = root;
        Node prev = null;
        
        // in order traversal
        while (stack.Count != 0 || cur != null) {
            // dig as far left
            while (cur != null) {
                stack.Push(cur);
                cur = cur.left;
            }
            
            cur = stack.Pop();
            head = head ?? cur; // assign left most node to head
            
            if (prev != null) {
                // link the 2 nodes
                prev.right = cur;
                cur.left = prev;
            }
            
            prev = cur;
            cur = cur.right;
        }
        
		// link last element with head. If only one Node, still linking to itself.
        head.left = prev;
        prev.right = head;
        
        return head;
        
    }
    
}