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
    public IList<int> RightSideView(TreeNode root) {
        if(root == null)
            return new List<int>();
        var res = new List<int>();
        
        var level = new Queue<TreeNode>();
        level.Enqueue(root);
        while(level.Count() > 0)
        {
            var amount = level.Count();
            var values = new Stack<int>();
            for(int i = 0; i < amount; i++)
            {
                var node = level.Dequeue();
                values.Push(node.val);
                if(node.left != null)
                    level.Enqueue(node.left);
                if(node.right != null)
                    level.Enqueue(node.right);
            }
            res.Add(values.Pop());
        }

        return res;
    }
}