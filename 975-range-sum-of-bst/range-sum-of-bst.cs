public class Solution {
    int sum = 0;
    public void DFS(TreeNode root, int low, int high)
    {
        if(root is null)
            return;
        
        if(root.val >= low && root.val <= high)
            sum+=root.val;
        
        DFS(root.left, low, high);
        DFS(root.right, low, high);
    }
    public int RangeSumBST(TreeNode root, int low, int high) {
        DFS(root, low, high);
        return sum;
    }
}