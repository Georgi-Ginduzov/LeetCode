public class Solution {
    public string Interpret(string command) {
        StringBuilder interpretator = new StringBuilder();
        for(int i = 0; i < command.Length - 1; i++)
        {
            if(command[i] == 'G')
            {
                interpretator.Append('G');
            }
            else
            {
                if(command[i+1] == ')')
                {
                    interpretator.Append('o');
                    i++;
                }
                else
                {
                    interpretator.Append("al");
                    i += 3;
                }
            }
        }
        if(command[command.Length - 1] == 'G')
        {
            interpretator.Append('G');
        }
        return interpretator.ToString();
    }
}