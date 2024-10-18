/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Preorder(Node root) {
        var res = new List<int>();
        Preorder(root, res);
        return res;
    }

    public void Preorder(Node root, IList res)
    {
        if(root == null)
            return;

        res.Add(root.val);
        foreach(var node in root.children)
        {
            Preorder(node, res);
        }
    }
}