public class Solution {
    public int DiameterOfBinaryTree(TreeNode root) {
        int d = 0;
        int DFS(TreeNode root, ref int d)
        {
            if(root is null)
                return 0;
            
            var left = DFS(root.left, ref d);
            var right = DFS(root.right, ref d);
            if(left+right > d)
                d = left + right;
            return 1 + (left > right ? left : right);
        }
        DFS(root, ref d);
        return d;
    }
}