public class Solution {
    public int[] ShortestToChar(string s, char c) {
        List<int> locations = new List<int>();
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == c)
                locations.Add(i);
        }
        int[] distances = new int[s.Length];
        for(int i = 0; i < s.Length; i++)
        {
            distances[i] = Math.Abs(i - locations[0]);
            for(int j = 1; j < locations.Count; j++)
            {
                distances[i] = distances[i] > Math.Abs(i - locations[j]) ? Math.Abs(i - locations[j]) : distances[i];
            }
        }
        return distances;
    }
}