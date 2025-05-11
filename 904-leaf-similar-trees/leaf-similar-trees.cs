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
    List<int> leaves1 = new List<int>();
    List<int> leaves2 = new List<int>();

    public void Leaves(TreeNode root)
    {
        if(root is null)
            return;
        
        if(root.left is null && root.right is null){
            leaves1.Add(root.val);
            return;
        }
        
        Leaves(root.left);
        Leaves(root.right);
    }

    public void LeavesTwo(TreeNode root)
    {
        if(root is null)
            return;
        
        if(root.left is null && root.right is null){
            leaves2.Add(root.val);
            return;
        }
        
        LeavesTwo(root.left);
        LeavesTwo(root.right);
    }

    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        Leaves(root1);
        LeavesTwo(root2);

        if(leaves1.Count != leaves2.Count)
            return false;
        
        for(int i = 0; i < leaves1.Count; i++)
        {
            if(leaves1[i] != leaves2[i])
                return false;
        }

        return true;
    }
}