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
    public bool HasCycle(ListNode head) {
        //return HasCycleHash(head);
        return HasCycleAlgo(head);
    }

    public bool HasCycleHash(ListNode head)
    {
        var nodes = new HashSet<ListNode>();

        while(head != null)
        {
            if(!nodes.Add(head))
                return true;
            head = head.next;
        }

        return false;
    }

    public bool HasCycleAlgo(ListNode head)
    {
        var slow = head;
        var fast = head;

        while(slow != null && fast != null)
        {
            slow = slow.next;
            if(fast.next == null)
                break;
                
            fast = fast.next.next;

            if(slow == fast)
                return true;
        }

        return false;
    }
}