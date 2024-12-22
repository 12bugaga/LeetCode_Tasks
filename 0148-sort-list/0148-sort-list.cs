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
    public ListNode SortList(ListNode head) {
        if(head == null || head.next == null)  
            return head;

        var mid = FindMiddle(head);
        var left = head;
        var right = mid.next;
        mid.next = null;

        left = SortList(left);
        right = SortList(right);

        return Merge(left, right);
    }

    public ListNode FindMiddle(ListNode head)
    {
        var slow = head;
        var fast = head;

        while(fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }

    public ListNode Merge(ListNode left, ListNode right)
    {
        var res = new ListNode();
        var current = res;

        while(left != null && right != null)
        {
            if(left.val < right.val)
            {
                current.next = left;
                left = left.next;
            }
            else
            {
                current.next = right;
                right = right.next;
            }

            current = current.next;
        }

        if(left != null)
            current.next = left;
        
        if(right != null)
            current.next = right;

        return res.next;
    }
}