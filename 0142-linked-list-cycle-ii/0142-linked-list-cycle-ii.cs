/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        if(head == null || head.next == null) {
            return null;
        }
        
        ListNode slow = head;
        ListNode fast = head;
        
        while(fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
            
            if(slow == fast) { // cycle
                break;
            }
        }
        
        if(fast == null || fast.next == null) {
            return null;
        }
        
        slow = head;
        
        while(slow != fast) {
            slow = slow.next;
            fast = fast.next;
        }
        
        return slow;
    }
}