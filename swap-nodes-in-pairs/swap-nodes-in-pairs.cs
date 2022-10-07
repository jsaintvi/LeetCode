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
    public ListNode SwapPairs(ListNode head) {
        
        if(head == null || head.next == null)
            return head;
        
        ListNode dummyHead = new ListNode(-1);
        dummyHead.next = head;

        var curr = head;
        var prev = dummyHead;

        while (curr != null && curr.next != null)
        {
            prev.next = curr.next;
            curr.next = curr.next.next;
            prev.next.next = curr;
            prev = curr;

            curr = curr.next;
        }

        return dummyHead.next;
                
    }
    

}