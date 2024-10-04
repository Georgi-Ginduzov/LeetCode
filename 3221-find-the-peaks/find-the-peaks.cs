public class Solution {
    public IList<int> FindPeaks(int[] mountain) {
        if(mountain.Length < 3)
        {
            return new List<int>();
        }
        List<int> peaks = new List<int>();
        for(int i = 1; i < mountain.Length - 1; i ++)
        {
            if(mountain[i] > mountain[i-1] && mountain[i] > mountain[i+1])
            {
                peaks.Add(i);
                i++;
            }
        }
        return peaks;
    }
}