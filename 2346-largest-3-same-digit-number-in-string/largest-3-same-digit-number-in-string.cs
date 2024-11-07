public class Solution {
    public string LargestGoodInteger(string num) {
        StringBuilder largest = new StringBuilder();
        for(int i = 1; i < num.Length - 1; i++)
        {
            if(num[i-1] == num[i] && num[i] == num[i+1])
            {
                if(largest.Length > 0) 
                {
                    if(largest[0] < num[i])
                    {
                        largest.Remove(0, 3);
                        largest.Append(num[i]);
                        largest.Append(num[i]);
                        largest.Append(num[i]);
                    }
                }
                else
                {
                    largest.Append(num[i]);
                    largest.Append(num[i]);
                    largest.Append(num[i]);
                }
            }
        }
        return largest.ToString();
    }
}