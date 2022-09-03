/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        
        if(root == null) return root;
        
        Queue<Node> q = new();
        
        q.Enqueue(root);
        
       while (q.Count > 0)
        {
            // curr level
           int currLevelNodeCount = q.Count;
                     
            // traverse curr level nodes and add them to list
            for(int i = 0; i < currLevelNodeCount; i++)
            {
                Node currNode = q.Dequeue();
                if(i < currLevelNodeCount - 1)
                {
                   currNode.next = q.Peek();

                }
                
                // queue left sybtree
                if(currNode.left != null)
                    q.Enqueue(currNode.left);

                // queue right subtree
                if(currNode.right != null)
                    q.Enqueue(currNode.right);

            }

        }
        
        return root;
    }
}