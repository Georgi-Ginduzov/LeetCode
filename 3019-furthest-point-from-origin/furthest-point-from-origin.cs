public class Solution {
    public int FurthestDistanceFromOrigin(string moves) {
        int l = 0;
        int r = 0;
        for(int i = 0; i < moves.Length; i++)
        {
            switch(moves[i])
            {
                case 'L':
                    l++;
                    continue;
                case 'R':
                    r++;
                    continue;
                default:
                    break;
            }
        }
        return (Math.Abs(l - r) + (moves.Length - l - r));
    }
}