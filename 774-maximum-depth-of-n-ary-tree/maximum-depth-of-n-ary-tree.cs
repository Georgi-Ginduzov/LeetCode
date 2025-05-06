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
    public int maxDepth = 0;

    public void Depth(Node root, int depth)
    {
        if(root is null)
            return;
        
        depth++;
        maxDepth = depth > maxDepth ? depth : maxDepth;

        foreach(var child in root.children)
        {
            Depth(child, depth);
        }
    }

    public int MaxDepth(Node root) {
        Depth(root, 0);
        return maxDepth;
    }
}