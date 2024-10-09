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
    public int SumNumbers(TreeNode root) {
        if(root == null)
            return 0;

        return SumNumbers(root, "");
    }

    public int SumNumbers(TreeNode root, string num)
    {
        if(root.left == null && root.right == null)
            return Int32.Parse(num + root.val);
        
        int sum = 0;
        if(root.left != null)
            sum +=SumNumbers(root.left, num + root.val);

        if(root.right != null)
            sum += SumNumbers(root.right, num + root.val);
            
        return sum;
    }
}