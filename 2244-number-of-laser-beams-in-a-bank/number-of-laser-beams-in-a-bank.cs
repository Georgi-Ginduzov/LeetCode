public class Solution {
    public int NumberOfBeams(string[] bank) {
        int numberOfBeams = 0;
        int previousRow = 0;
        foreach(var row in bank)
        {
            int rowBeams = 0;
            for(int i = 0; i < row.Length; i++)
                rowBeams += (row[i] & 1);
            if(rowBeams > 0)
            {
                numberOfBeams += (previousRow * rowBeams);
                previousRow = rowBeams;
            }
        }

        return numberOfBeams;
    }
}