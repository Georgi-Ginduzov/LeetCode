public class Solution {
    private TreeNode newRoot;
    private TreeNode newTree;

    public Solution()
    {
        newRoot = new TreeNode(0);
        newTree = newRoot;
    }

    public TreeNode IncreasingBST(TreeNode root) {
        if(root is null)
            return newTree.right;
        
        IncreasingBST(root.left);
        newRoot.right = new TreeNode(root.val);
        newRoot = newRoot.right;
        IncreasingBST(root.right);

        return newTree.right;
    }
}