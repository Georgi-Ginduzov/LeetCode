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
    TreeNode xParent;
    int xDepth;
    TreeNode yParent;
    int yDepth;
    
    public void DFS(TreeNode root, int depth, TreeNode parent, int x, int y)
    {
        if(root is null)
            return;
        
        if(root.val == x)
        {
            xParent = parent;
            xDepth = depth;
        }
        else if(root.val == y)
        {
            yParent = parent;
            yDepth = depth;
        }

        DFS(root.left, depth + 1, root, x, y);
        DFS(root.right, depth + 1, root, x, y);
    }
    public bool IsCousins(TreeNode root, int x, int y) {
        DFS(root, 0, root, x, y);
        return xParent.val != yParent.val && xDepth == yDepth;
    }
}