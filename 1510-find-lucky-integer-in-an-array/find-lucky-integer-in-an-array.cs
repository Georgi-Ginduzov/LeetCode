public class Solution {
    public int FindLucky(int[] arr) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(int num in arr)
        {
            if(dict.ContainsKey(num))
                dict[num]++;
            else
                dict.Add(num, 1);
        }
        int luckyNum = -1;
        foreach(var pair in dict)
        {
            if(pair.Key == pair.Value && pair.Key > luckyNum)
                luckyNum = pair.Key;
        }
        return luckyNum;
    }
}
