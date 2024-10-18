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
    public IList<IList<int>> LevelOrder(Node root) {
        if(root == null) 
            return new List<IList<int>>();
            
         var res = new List<IList<int>>();
         var level = new Queue<Node>();
         level.Enqueue(root);

         while(level.Count > 0)
         {
            var amount = level.Count();
            var values = new List<int>();
            for(int i = 0; i < amount; i++)
            {
                var node = level.Dequeue();
                values.Add(node.val);

                foreach(var child in node.children)
                {
                    level.Enqueue(child);
                }
            }

            res.Add(values);
         }

         return res;
    }
}