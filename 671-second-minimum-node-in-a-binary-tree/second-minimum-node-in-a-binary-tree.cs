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
    public int FindSecondMinimumValue(TreeNode root) {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        long secondMin = long.MaxValue;

        while(queue.Count > 0)
        {
            var el = queue.Dequeue();
            if(el is null)
                continue;
            else if(el.val > root.val && secondMin >= el.val)
                secondMin = el.val;
            
            queue.Enqueue(el.left);
            queue.Enqueue(el.right);
        }

        return secondMin == long.MaxValue ? -1 : (int)secondMin;
    }
}