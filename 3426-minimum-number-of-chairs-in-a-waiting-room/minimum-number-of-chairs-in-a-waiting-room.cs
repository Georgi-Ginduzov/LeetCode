public class Solution {
    public int MinimumChairs(string s) {
        int minimumChairs = 0;
        int currentChairs = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == 'E')
                currentChairs++;
            else
                currentChairs--;
            minimumChairs = minimumChairs < currentChairs ? currentChairs : minimumChairs;
        }
        return minimumChairs;
    }
}