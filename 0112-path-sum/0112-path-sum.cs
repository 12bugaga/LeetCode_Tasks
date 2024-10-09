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
    public bool HasPathSum(TreeNode root, int targetSum) {
        if(root == null)
            return false;

        targetSum -= root.val;
        if(targetSum == 0 && root.left == null && root.right == null)
            return true;
        
        bool left = HasPathSum(root.left, targetSum);
        if(left)
            return left;
        
        return HasPathSum(root.right, targetSum);
    }
}