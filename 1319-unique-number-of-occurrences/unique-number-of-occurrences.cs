public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> uniqueValues = new Dictionary<int, int>();
        for(int i = 0; i < arr.Length; i++)
        {
            if(uniqueValues.TryAdd(arr[i], 1) == false)
            {
                uniqueValues[arr[i]]++;
            }
        }
        HashSet<int> ocurrences = new HashSet<int>();
        foreach(var val in uniqueValues)
        {
            if(ocurrences.Add(val.Value) == false)
            {
                return false;
            }
        }
        return true;
    }
}