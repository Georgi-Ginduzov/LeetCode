public class Solution {
    public string MakeSmallestPalindrome(string s) {
        char[] palindrome = s.ToCharArray();
        for(int i = 0; i < s.Length / 2; i++)
        { 
            if(s[i] == s[s.Length - 1 - i])
                continue;
            else if(s[i] < s[s.Length - 1 - i])
                palindrome[s.Length - 1 - i] = palindrome[i];
            else
                palindrome[i] = palindrome[s.Length - 1 - i];
        }
        return new string(palindrome);
    }
}