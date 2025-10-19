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
    public int SumRootToLeaf(TreeNode root) {
        int sum = 0;

        void Dfs(TreeNode root, string path)
        {
            if(root is null)
                return;
            
            path += root.val.ToString();
            Dfs(root.left, path);
            Dfs(root.right, path);

            if(root.left is null && root.right is null)
                sum += Convert.ToInt32(path.ToString(), 2);
        }

        Dfs(root, "");

        return sum;
    }
}