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
    public IList<int> PostorderTraversal(TreeNode root) {
        var res = new List<int>();
        PostorderTraversal(root, res);

        return res;
    }

    public void PostorderTraversal(TreeNode root, IList<int> res)
    {
        if(root == null) 
            return;

        PostorderTraversal(root.left, res);
        PostorderTraversal(root.right, res);
        res.Add(root.val);
    }
}