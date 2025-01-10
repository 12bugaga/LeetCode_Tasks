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
    public void ReorderList(ListNode head) {
        
        var curr = head;

        var q = new Queue<int>();
        var s = new Stack<int>();
        var count = 0;

        while (curr != null)
        {
            q.Enqueue(curr.val);
            
            s.Push(curr.val);
            count++;

            curr = curr.next;
        }
        curr = head;

        for (int i = 0; i < count; i++)
        {
            if (i % 2 == 0)
                curr.val = q.Dequeue();
            else
                curr.val = s.Pop();

            curr = curr.next;
        }
    }
}