public class Solution {
    private int min = 100001;

    private int Min(TreeNode root, int depth)
    {
        if(root is null)
            return 0;
        Min(root.left, depth+1);
        Min(root.right, depth+1);
        if(root.left is null && root.right is null)
            min = min < depth ? min : depth;
        return min;
    }
    public int MinDepth(TreeNode root) {
        return Min(root, 1);
    }
}