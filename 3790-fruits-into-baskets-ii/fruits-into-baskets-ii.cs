public class Solution {
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets) {
        HashSet<int> filled = new HashSet<int>(baskets.Length);
        foreach(var fruit in fruits)
        {
            for(int i = 0; i < baskets.Length; i++)
            {
                if(filled.Contains(i))
                    continue;
                if(baskets[i] >= fruit)
                {
                    filled.Add(i);
                    break;
                }
            }
        }
        return fruits.Length - filled.Count;
    }
}