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
    
    public bool IsBalanced(TreeNode root) {
        
        (bool isBalanced, int depth) Traverse(TreeNode root, int depth)
        {
            if(root is null)
                return (true, depth);

            var left = Traverse(root.left, depth + 1);
            if(!left.isBalanced)
                return (false, depth);
            var right = Traverse(root.right, depth +1);
            if(!right.isBalanced)
                return (false, depth);
            
            if(Math.Abs(left.depth - right.depth) > 1)
                return (false, depth);
            
            if(left.depth > right.depth)
                return (true, left.depth);
            else 
                return (true, right.depth);
        }
        
        (var isBalanced, var depth) = Traverse(root, 0);

        return isBalanced;
    }
}