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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        if (root == null)
    return new List<IList<int>>();

    var res = new List<IList<int>>();
    var stack = new Stack<TreeNode>();
    
    stack.Push(root);
    bool leftRight = false;

    while (stack.Count() > 0)
    {
        var temp = new Stack<TreeNode>();
        var level = new List<int>();
        int amount = stack.Count();
        for (int i = 0; i < amount; i++)
        {
            var main = stack.Pop();
            level.Add(main.val);
            if (!leftRight)
            {
                if (main.left != null)
                    temp.Push(main.left);
                if (main.right != null)
                    temp.Push(main.right);
            }
            else
            {
                if (main.right != null)
                    temp.Push(main.right);
                if (main.left != null)
                    temp.Push(main.left);
            }
        }
        res.Add(level);
        leftRight = !leftRight;
        stack = temp;
    }

    return res;
    }
}