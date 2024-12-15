public class Solution {
    public int DistributeCandies(int[] candyType) {
        HashSet<int> types = new HashSet<int>();
        for(int i = 0; i < candyType.Length; i++)
        {
            types.Add(candyType[i]);
            if(types.Count == candyType.Length / 2)
                return types.Count;
        }
        return types.Count;
    }
}