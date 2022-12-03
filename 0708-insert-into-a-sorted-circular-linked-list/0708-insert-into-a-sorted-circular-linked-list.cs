/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
        next = null;
    }

    public Node(int _val, Node _next) {
        val = _val;
        next = _next;
    }
}
*/

public class Solution {
    public Node Insert(Node head, int insertVal) {
        if(head == null) {
            var node = new Node(insertVal);
            node.next = node;
            
            return node;
        }
        
        Node prev = head;
        Node curr = head.next;
        bool toInsert = false;
        do{
            // case 1 : value between min and max value
           if(Isbetween(prev.val, curr.val, insertVal)) {
               toInsert = true;
           }else if(prev.val > curr.val) { // if true -> tail: prev and head: curr
               
               // case 2.1: value to insert  >= val of tail node
               // case 2.2: value to insert  <= val of head node
               if(insertVal >= prev.val || insertVal <= curr.val) {
                   toInsert = true;
               }
           }
            
            if(toInsert) {
                prev.next = new Node(insertVal, curr);
                return head;
            }
            
            // advance pointers
            prev= curr;
            curr = curr.next;
            
        }while(prev != head);

        // case 3: list contains uniform values (ex: linked list with all 3's as values)
        prev.next = new Node(insertVal, curr);
        return head;
    }
    
    private bool Isbetween(int lowerbound, int upperBound, int valueTocheck) {
      return lowerbound <= valueTocheck && valueTocheck <= upperBound;  
    }
}