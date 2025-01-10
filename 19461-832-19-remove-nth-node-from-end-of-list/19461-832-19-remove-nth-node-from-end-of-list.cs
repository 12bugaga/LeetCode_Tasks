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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        
        var list = new List<ListNode>();
        var temp = head;
        
        while(head != null)
        {
            list.Add(head);
            head = head.next;
        }

        if (n == 1 && list.Count() == 1)
            return null;
        else if (n == 1)
            list[list.Count() - 2].next = null;
        else if(n == list.Count())
            return temp.next;
        else
            list[list.Count() - n - 1].next = list[list.Count() - n + 1]; 

        return temp;
    }
}