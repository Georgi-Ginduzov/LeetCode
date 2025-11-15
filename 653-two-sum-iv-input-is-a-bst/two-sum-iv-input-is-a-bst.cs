public class Solution {
    private HashSet<int> set = new HashSet<int>();

    public bool FindTarget(TreeNode root, int k) {
        if(root is null)
            return false;
        if(set.Contains(k - root.val))
            return true;
        set.Add(root.val);
        if(FindTarget(root.left, k))
            return true;
        return FindTarget(root.right, k);
    }
}