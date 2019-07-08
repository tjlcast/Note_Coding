/**
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example:

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8
Explanation: 342 + 465 = 807.
**/


public class Solution {
	/**
	* Definition for singly-linked list.
	* public class ListNode {
	*     public int val;
	*     public ListNode next;
	*     public ListNode(int x) { val = x; }
	* }
	*/
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode resultRoot = new ListNode(-1);
        ListNode resultN = resultRoot; 
        ListNode l1N = l1, l2N = l2; 
        int carry = 0; 

        while (l1N!=null || l2N!=null) {
        	int val1 = (l1N==null) ? (0) : (l1N.val); 
        	int val2 = (l2N==null) ? (0) : (l2N.val); 
        	int total = carry + val1 + val2; 

        	ListNode tmpN = new ListNode(total % 10); 
        	resultN.next = tmpN; 
        	resultN = tmpN; 
        	carry = total / 10; 

        	if (l1N!=null) l1N = l1N.next; 
        	if (l2N!=null) l2N = l2N.next; 
        } 
        if (carry != 0) {
        	ListNode tmpN = new ListNode(carry); 
        	resultN.next = tmpN; 
        	resultN = tmpN; 
        }

        return resultRoot.next; 
    }
}