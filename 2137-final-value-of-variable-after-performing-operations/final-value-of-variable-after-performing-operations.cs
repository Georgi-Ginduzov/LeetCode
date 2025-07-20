public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int x = 0;
        foreach(var operation in operations)
        {
            if(operation[0] == '-' || operation[operation.Length - 1] == '-')
                x--;
            else
                x++;
        }

        return x;
    }
}