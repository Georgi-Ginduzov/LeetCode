public class Solution {
    public bool IsBalanced(string num) {
        int balance = 0;
        for(int i = 0; i < num.Length; i++)
        {
            if(i % 2 == 0)
            {
                balance += (num[i] - '0');
            }
            else
                balance -= (num[i] - '0');
        }
        return balance == 0;
    }
}