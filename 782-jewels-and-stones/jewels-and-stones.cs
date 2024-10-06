public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        var types = new HashSet<char>(jewels);
        int money = 0;
        foreach(var stone in stones)
        {
            if(types.Contains(stone))
            {
                money++;
            }
        }
        return money;
    }
}