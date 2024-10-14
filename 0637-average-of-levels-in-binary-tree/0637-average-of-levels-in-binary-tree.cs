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
        public IList<double> AverageOfLevels(TreeNode root) {
            var res = new List<double>();
            Queue<TreeNode> level = new Queue<TreeNode>();
            TreeNode node = new TreeNode();
            long sum = 0;
            long amount = 0;
            level.Enqueue(root);

            while(level.Count > 0)
            {
                sum = 0;
                amount = level.Count;

                for(int i = 0; i < amount; i++)
                {
                    node = level.Dequeue();

                    sum += node.val;
                    if(node.left != null)
                        level.Enqueue(node.left);
                    if(node.right != null)
                        level.Enqueue(node.right);
                }
                res.Add(sum * 1.0 / amount);
            }

            return res;
        }
}