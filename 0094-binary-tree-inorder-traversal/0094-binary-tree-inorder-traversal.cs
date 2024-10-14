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
    public IList<int> InorderTraversal(TreeNode root) {
        var res = new List<int>(); 
        InorderTraversal(root, res);
        return res;
    }

    public void InorderTraversal(TreeNode root, IList<int> res)
    {
        if(root == null)
            return;
        InorderTraversal(root.left, res);
        res.Add(root.val);
        InorderTraversal(root.right, res);
    }
}