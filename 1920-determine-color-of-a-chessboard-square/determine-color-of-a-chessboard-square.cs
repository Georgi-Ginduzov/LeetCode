public class Solution {
    public bool SquareIsWhite(string coordinates) {
        return (coordinates[0] % 2 == 'a' % 2 && coordinates[1] % 2 =='4' % 2) || (coordinates[0] % 2 == 'b' % 2 && coordinates[1] % 2 == '3' % 2);
    }
}