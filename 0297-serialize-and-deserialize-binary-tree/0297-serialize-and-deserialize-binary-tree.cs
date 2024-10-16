/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
using System.Text.Json;
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if(root == null)
            return "[]";

        var res = new List<int?>();
        var level = new Queue<TreeNode>();
        level.Enqueue(root);

        while(level.Count() > 0)
        {
            var amount = level.Count();

            for(int i = 0; i < amount; i++)
            {
                var node = level.Dequeue();
                res.Add(node?.val);
                if (node != null)
                {
                    level.Enqueue(node.left);
                    level.Enqueue(node.right);
                }
            }
        }

        return JsonSerializer.Serialize(res);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        var tree = JsonSerializer.Deserialize<int?[]>(data);
        var amount = tree.Length;
        if(amount == 0)
            return null;

        int i = 0;
        var res = new TreeNode(tree[0].Value);
        i++;
        var level = new Queue<TreeNode>();
        level.Enqueue(res);
        while(level.Count() > 0)
        {
            var node = level.Dequeue();
            if(i >= amount) break;
            if(tree[i] != null)
            {
                node.left = new TreeNode(tree[i].Value);
                level.Enqueue(node.left);
            }
            i++;
            if(i >= amount) break;
            if(tree[i] != null)
            {
                node.right = new TreeNode(tree[i].Value);
                level.Enqueue(node.right);
            }
            i++;
        }
        return res;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));