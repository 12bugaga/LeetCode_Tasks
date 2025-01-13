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
    public int[] Array { get; set; }
    public int KthSmallest(TreeNode root, int k) {
        var arr = new List<int>();
        DFS(root, arr);

        return arr[k - 1];
    }

    public void DFS(TreeNode root, List<int> arr)
    {
        if(root == null)
            return;
        
        DFS(root.left, arr);
        arr.Add(root.val);
        DFS(root.right, arr);
    }
}