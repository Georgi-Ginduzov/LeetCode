public class Solution {
    public bool JudgeCircle(string moves) {
        int x = 0; 
        int y = 0;
        for(int i = 0; i < moves.Length; i++)
        {
            switch(moves[i])
            {
                case 'U':
                    x++;
                    break;
                case 'D':
                    x--;
                    break;
                case 'L':
                    y--;
                    break;
                case 'R':
                    y++;
                    break;
            }
        }
        return x == 0 && y == 0;
    }
}