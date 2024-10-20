public class Solution {
    public int MinOperations(string[] logs) {
        int steps = 0;
        for(int i = 0; i < logs.Length; i++)
        {
            switch(logs[i])
            {
                case "../":            
                    steps -= steps == 0 ? 0 : 1;
                    continue;
                case "./":
                    continue;
                default:
                    steps++;
                    break;
            }
        }
        return steps;
    }
}