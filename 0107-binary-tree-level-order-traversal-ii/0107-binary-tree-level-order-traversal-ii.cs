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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        var res = new List<IList<int>>();

        if(root == null)
            return res;

        var level = new Queue<TreeNode>();
        level.Enqueue(root);

        while(level.Count() > 0)
        {
            var len = level.Count();
            var list = new List<int>();
            for(int i = 0; i < len; i++)
            {
                var node = level.Dequeue();
                list.Add(node.val);
                if(node.left != null)
                    level.Enqueue(node.left);
                if(node.right != null)
                    level.Enqueue(node.right);
            }
            res.Insert(0, list);
        }

        return res;
    }
}