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
    public int MinimumOperations(TreeNode root) {
        
        int amount = 0;
        // BFS
        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count > 0)
        {
            var count = q.Count();
            var level = new int[count];

            for(int i = 0; i < count; i++)
            {
                var point = q.Dequeue();
                level[i] = point.val;

                if(point.left != null)
                    q.Enqueue(point.left);
                if(point.right != null)
                    q.Enqueue(point.right);
            }
            amount += SwapAmount(level);
        }

        return amount;
    }

    public int SwapAmount(int[] arr)
    {
        int amount = 0;
        var mapIndex = new Dictionary<int, int>();
        var sort = arr.OrderBy(a => a).ToArray();

        for(int i = 0; i < arr.Length; i++)
            mapIndex.Add(arr[i], i);

        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] != sort[i])
            {
                var j = mapIndex[sort[i]];
                (arr[j], arr[i]) = (arr[i], arr[j]);
                mapIndex[arr[j]] = j;
                amount++;
            }
        }

        return amount;
    }
}