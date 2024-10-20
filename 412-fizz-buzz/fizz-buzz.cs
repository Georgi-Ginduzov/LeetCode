public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> result = new List<string>();
        for(int i = 1; i <=n; i++)
        {
            StringBuilder str = new StringBuilder();
            if(i % 3 == 0)
            {
                str.Append("Fizz");
            }
            if(i % 5 == 0)
            {
                str.Append("Buzz");
            }
            else
            {
                if(i % 3 != 0)
                    str.Append(i.ToString());
            }
            result.Add(str.ToString());
        }
        return result;
    }
}