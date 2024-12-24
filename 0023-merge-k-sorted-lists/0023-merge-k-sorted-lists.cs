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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists.Length == 0)
            return null;
        if(lists.Length == 1)
            return lists[0];

        int mid = lists.Length / 2;
        var left = new ListNode[mid];
        var right = new ListNode[lists.Length - mid];

        for(int i = 0; i < mid; i++)
            left[i] = lists[i];

        for(int i = 0; i < lists.Length - mid; i++)
            right[i] = lists[mid + i];

        var l = MergeKLists(left);
        var r = MergeKLists(right);

        return Merge(l, r);
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