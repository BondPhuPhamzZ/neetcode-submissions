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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        List<int> values = new List<int>();

        while (list1 != null)
        {
            values.Add(list1.val);
            list1 = list1.next;
        }
        while (list2 != null)
        {
            values.Add(list2.val);
            list2 = list2.next;
        }

        if (values.Count == 0)
        {
            return null;
        }

        values.Sort();

        ListNode head = new ListNode(values[0]);
        ListNode current = head;
        for (int i = 1; i < values.Count; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }

        return head;

    }
}