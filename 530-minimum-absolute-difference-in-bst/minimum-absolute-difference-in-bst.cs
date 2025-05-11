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
    List<int> items = new List<int>();

    public void ExtractTreeItems(TreeNode root)
    {
        if(root is null)
            return;
        
        ExtractTreeItems(root.left);
        items.Add(root.val);
        ExtractTreeItems(root.right);
    }

    public int GetMinimumDifference(TreeNode root) {
        ExtractTreeItems(root);

        int smallest = 100000;
        for(int i = 1; i < items.Count; i++)
        {
            if(items[i] - items[i-1] < smallest)
                smallest = items[i] - items[i-1];
        }

        return smallest;
    }
}