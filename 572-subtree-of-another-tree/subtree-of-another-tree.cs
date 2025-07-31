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
    public bool SubtreeRoot(TreeNode root, TreeNode subroot)
    {
        if(root is null)
            return false;
        
        if(root.val == subroot.val && AreEqual(root, subroot))
            return true;
        
        if(SubtreeRoot(root.left, subroot))
            return true;
        else
            return SubtreeRoot(root.right, subroot);
    }

    public bool AreEqual(TreeNode root, TreeNode root2)
    {
        if(root is null)
            if(root2 is null)
                return true;
            else
                return false;
        else if(root2 is null)
            return false;
        
        if(!AreEqual(root.left, root2.left))
            return false;
        else if(!AreEqual(root.right, root2.right))
            return false;
        
        if(root.val != root2.val)
            return false;
        
        return true;
    }

    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        return SubtreeRoot(root, subRoot);
    }
}