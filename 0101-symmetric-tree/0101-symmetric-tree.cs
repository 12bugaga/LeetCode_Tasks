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
    public bool IsSymmetric(TreeNode root) {
        if(root == null)
            return true;
        
        return IsSymmetric(root.left, root.right);
    }

    public bool IsSymmetric(TreeNode l, TreeNode r)
    {
        if (l == null && r == null)
            return true;
        else if (l == null || r == null)
            return false;

        if (l.left?.val != r.right?.val || l.right?.val != r.left?.val || l.val != r.val)
            return false;
        
        bool left = IsSymmetric(l.left, r.right);
        if(!left)
            return left;

        return IsSymmetric(l.right, r.left);
    }
}