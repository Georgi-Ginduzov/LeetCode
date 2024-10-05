public class Solution {
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime) {
        int students = 0;
        for(int i = 0; i < startTime.Length; i++)
        {
            if(endTime[i] >= queryTime && startTime[i] <= queryTime)
            {
                students++;
            }
        }
        return students;
    }
}