public class Solution {
    public string DigitSum(string s, int k) {
        if(s.Length <= k)
            return s;
        StringBuilder dSum = new StringBuilder(s);
        do
        {
            StringBuilder word = new StringBuilder();
            for (int i = 0; i < dSum.Length; i++)
            { 
                int sum = 0;
                for (int j = 0; j < k && i < dSum.Length; j++)
                {
                    sum += dSum[i++] - '0';
                }
                word.Append(sum);
                i--;
            } 
            dSum = word;
        } while (dSum.Length > k);

        return dSum.ToString();
    }
}