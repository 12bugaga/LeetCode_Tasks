/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Postorder(Node root) {
        var res = new List<int>();
        Postorder(root, res);
        return res;    
    }

    public void Postorder(Node root, IList<int> res)
    {
        if(root == null)
            return;

        foreach(var node in root.children)
        {
            Postorder(node, res);
        }
        res.Add(root.val);
    }
}