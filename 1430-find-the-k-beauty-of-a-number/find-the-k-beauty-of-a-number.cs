public class Solution {
    public int DivisorSubstrings(int num, int k) {
        string number = num.ToString();
        int valid = 0;
        for(int i = 0; i < number.Length - k + 1; i++)
        {
            int n = int.Parse(number.Substring(i, k));
            if(n != 0 && num % n == 0)
            {
                valid++;
            }
        }
        return valid;
    }
}