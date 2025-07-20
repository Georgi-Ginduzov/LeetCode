public class Solution {
    public string KthDistinct(string[] arr, int k) {
        if(arr.Length < k)
            return "";
        var map = new Dictionary<string, int>(arr.Length);
        foreach(var s in arr)
            if(map.ContainsKey(s))
                map[s]++;
            else
                map.Add(s, 1);
        
        int i = 0;
        foreach(var s in arr)
        {
            if(i > k)
                return "";
            if(map[s] != 1)
                continue;
            i++;
            
            if(i == k)
                return s;
        }

        return "";
    }
}