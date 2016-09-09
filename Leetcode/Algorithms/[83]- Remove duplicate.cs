/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;
            var currentNode = head;
            while (currentNode.next != null)
            {
                while (currentNode.val == currentNode.next.val)
                {
                    currentNode.next = currentNode.next.next;
                    if (currentNode.next == null)
                    {
                        return head;
                    }
                }
                currentNode = currentNode.next;
            }
            return head;
        }
}
