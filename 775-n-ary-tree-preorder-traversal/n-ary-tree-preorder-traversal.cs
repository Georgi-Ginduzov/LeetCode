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
    List<int> arr = new List<int>();
    
    public IList<int> Preorder(Node root) {
        if(root == null)
            return arr;

        arr.Add(root.val);
        foreach(var node in root.children)
        {
            Preorder(node);
        }

        return arr;
    }
}