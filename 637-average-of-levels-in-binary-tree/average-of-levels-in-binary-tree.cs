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
    public IList<double> AverageOfLevels(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        List<double> levels = new List<double>();

        while(queue.Count > 0)
        {
            double sum = 0;
            double denominator = queue.Count;
            for(int i = 0; i < denominator; i++)
            {
                var temp = queue.Dequeue();
                sum += temp.val;

                if(temp.left != null) 
                    queue.Enqueue(temp.left);
                if(temp.right != null)
                    queue.Enqueue(temp.right);
            }

            levels.Add(sum/denominator);
        }
        return levels;
    }
}