public class Solution {
    public int[] MinOperations(string boxes) {
        int[] operations = new int[boxes.Length];

        for(int i = 0; i < boxes.Length; i++)
        {
            for(int j = 0; j < boxes.Length; j++)
            {
                if(j == i)
                    continue;

                operations[i] += ((boxes[j] - '0') * Math.Abs(j-i));
            }
        }

        return operations;
    }
}