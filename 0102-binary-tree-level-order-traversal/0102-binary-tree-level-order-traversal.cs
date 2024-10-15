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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var res = new List<IList<int>>();
        if(root == null)
            return res;
            
        var level = new Queue<TreeNode>();
        level.Enqueue(root);

        while(level.Count() > 0)
        {
            var arr = new List<int>();
            int amount = level.Count();
            for(int i = 0; i < amount; i++)
            {
                var node = level.Dequeue();
                arr.Add(node.val);
                if(node.left != null)
                    level.Enqueue(node.left);
                if(node.right != null)
                    level.Enqueue(node.right);
            }
            res.Add(arr);
        }
        return res;
    }
}