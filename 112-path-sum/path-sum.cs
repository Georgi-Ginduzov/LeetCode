public class Solution {
    private bool HasSum(TreeNode root, int targetSum, int currentSum)
    {
        if(root is null)
            return false;
        
        currentSum += root.val;
        if(currentSum == targetSum && root.left is null && root.right is null)
            return true;

        if(HasSum(root.left, targetSum, currentSum))
            return true;
        return HasSum(root.right, targetSum, currentSum);
    }

    public bool HasPathSum(TreeNode root, int targetSum) {
        return HasSum(root, targetSum, 0);
    }
}