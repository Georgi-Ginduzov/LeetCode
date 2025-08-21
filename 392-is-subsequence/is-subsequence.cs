/*
Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
    - I receive 2 strings
    - I have to determine if s is a subsequence of t

A subsequence of a string is a new string that is formed from the original string 
    - by skipping some of the characters
        - skip a character
            - ensure there are more 
    - by skipping none of the characters
        - if the current char in s is equal to the current one in t
    - relative positions of the remaining characters are not disturbed
        - (i.e., "ace" is a subsequence of "abcde" while "aec" is not).




*/
public class Solution {
    public bool IsSubsequence(string s, string t) {
        int i = 0; 
        int j = 0;

        while(i<s.Length)
        {
            while(true)
            {
                if(j >= t.Length)
                    return false;
                if(t[j++] == s[i])
                    break;
            }
            
            i++;
        }

        return true;
    }
}