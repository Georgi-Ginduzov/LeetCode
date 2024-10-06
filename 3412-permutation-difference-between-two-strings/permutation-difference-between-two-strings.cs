public class Solution {
    public int FindPermutationDifference(string s, string t) {
        int sum = 0;
        for(int i = 0; i < s.Length; i++)
        {
            int j = 0;
            while(j < t.Length)
            {
                if(s[i] == t[j])
                {
                    sum += Math.Abs(i-j);
                    j = t.Length;
                }
                j++;
            }
        }
        return sum;
    }
}