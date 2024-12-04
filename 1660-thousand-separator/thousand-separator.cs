public class Solution {
    public string ThousandSeparator(int n) {
        StringBuilder num = new StringBuilder(n.ToString());
        for (int i = num.Length - 3; i > 0; i -= 3)
        {
            num.Insert(i, '.');
        }
        return num.ToString();
    }
}