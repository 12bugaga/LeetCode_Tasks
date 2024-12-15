/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        return Compute(0, nums.Length - 1, nums);
}
    public TreeNode Compute (int start, int end, int[] nums)
    {
        if (start > end)
            return null;
        var mid = (start + end) / 2;
        var res = new TreeNode(nums[mid], Compute(start, mid - 1, nums), Compute(mid + 1, end, nums));

        return res;
    }
}