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
    public bool IsValidBST(TreeNode root) {
        
        return IsValid(root, null, null);
    }

    public bool IsValid(TreeNode root, int? left, int? right)
    {
        if(root == null)
            return true;
        if((left != null && root.val <= left) ||
            (right != null && root.val >= right))
            return false;

        return IsValid(root.left, left, root.val) &&
                IsValid(root.right, root.val, right);
    }
}