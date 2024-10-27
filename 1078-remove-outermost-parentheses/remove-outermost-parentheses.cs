public class Solution {
    public string RemoveOuterParentheses(string s) {
        Stack<char> stack = new Stack<char>();
        StringBuilder res = new StringBuilder();
        foreach(var c in s)
        {
            if(c is'(')
            {
                if(stack.Count > 0)
                {
                    res.Append('(');
                }
                stack.Push(c);
            }
            else
            {
                if(stack.Count > 1)
                {
                    res.Append(')');
                }
                stack.Pop();
            }
        }
        return res.ToString();
    }
}