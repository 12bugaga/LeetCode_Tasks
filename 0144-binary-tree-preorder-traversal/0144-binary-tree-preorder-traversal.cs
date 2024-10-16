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
    public IList<int> PreorderTraversal(TreeNode root) {
        var res = new List<int>();
        PreorderTraversal(root, res);
        return res;
    }

    public void PreorderTraversal(TreeNode root, IList<int> list)
    {
        if(root == null) return;

        list.Add(root.val);
        PreorderTraversal(root.left, list);
        PreorderTraversal(root.right, list);
    }
}