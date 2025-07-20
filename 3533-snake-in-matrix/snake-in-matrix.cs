public class Solution {
    public int FinalPositionOfSnake(int n, IList<string> commands) {
        int i = 0;
        foreach(var command in commands)
        {
            switch(command)
            {
                case "UP":
                    i -= n;
                    break;
                case "DOWN":
                    i += n;
                    break;
                case "LEFT":
                    i--;
                    break;
                case "RIGHT":
                    i++;
                    break; 
            }
        }

        return i;
    }
}