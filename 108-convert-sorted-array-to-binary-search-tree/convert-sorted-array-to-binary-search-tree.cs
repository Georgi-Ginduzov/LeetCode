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
    public TreeNode SortedArrayToBST(int[] nums) {
        return Construct(nums, 0, nums.Length - 1);
    }

    public TreeNode Construct(int[] nums, int low, int high)
    {
        TreeNode root = null;

        if(low <= high)
        {
            int mid = low + (high-low) / 2;

            root = new TreeNode(nums[mid]);
            root.left = Construct(nums, low, mid-1);
            root.right = Construct(nums, mid+1, high);
        }

        return root;
    }
}