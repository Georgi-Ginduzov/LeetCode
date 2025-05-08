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
    List<string> paths = new List<string>();

    public void Paths(TreeNode root, string path)
    {
        if(root is null)
            return;

        path += root.val.ToString();

        if(root.left != null)
            Paths(root.left, path + "->");

        if(root.right != null)
            Paths(root.right, path + "->");
        
        if(root.left == null && root.right == null)
            paths.Add(path);
    }

    public IList<string> BinaryTreePaths(TreeNode root) {
        Paths(root, "");
        return paths;
    }
}