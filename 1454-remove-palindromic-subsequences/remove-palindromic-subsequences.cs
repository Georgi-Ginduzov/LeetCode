public class Solution {
    public int RemovePalindromeSub(string s) {
         if (IsPalindrome(s)) {
            return 1;
        }
        return 2;
    }
    private bool IsPalindrome(string s) {
        int left = 0, right = s.Length - 1;
        while (left < right) {
            if (s[left] != s[right]) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}