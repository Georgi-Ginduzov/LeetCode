public class Solution {
    private TreeNode parentX;
    private TreeNode parentY;
    private int depthX;
    private int depthY;
    
    private void Dfs(TreeNode root, int x, int y, int depth, TreeNode parent)
    {
        if(root is null)
            return;
        
        if(root.val == x)
        {
            parentX = parent;
            depthX = depth;
        }
        else if(root.val == y)
        {
            parentY = parent;
            depthY = depth;
        }

        Dfs(root.left, x, y, depth+1, root);
        Dfs(root.right, x, y, depth+1, root);
    }    

    public bool IsCousins(TreeNode root, int x, int y) {
        Dfs(root, x, y, 0, root);

        return parentX.val != parentY.val && depthX == depthY;
    }
}