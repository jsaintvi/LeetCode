/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode dummyNode = new ListNode(-1);
        
        ListNode tail = dummyNode;
        while(l1 != null && l2 != null)
        {
            if(l1.val <= l2.val) {
                // add l1
                tail.next = l1;
                l1 = l1.next;
                
            } else {
                tail.next = l2;
                l2 = l2.next;
            }
            
            // advance tail pointer
            tail = tail.next;
        }
        
        tail.next = l1 == null ? l2 : l1;
        
        return dummyNode.next;
    }
}