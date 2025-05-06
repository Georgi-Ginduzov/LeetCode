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
    public int sum = 0;

    public void Traverse(TreeNode root, string num)
    {
        if(root is null)
            return;

        num += root.val.ToString();
        if(root.left == null && root.right == null)
            sum += Convert.ToInt32(num, 2);
        else
        {
            Traverse(root.left, num);
            Traverse(root.right, num);
        }
    }

    public int SumRootToLeaf(TreeNode root) {
        Traverse(root, "");
        return sum;
    }
}