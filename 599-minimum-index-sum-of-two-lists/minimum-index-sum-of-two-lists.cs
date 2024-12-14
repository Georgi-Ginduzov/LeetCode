public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
        Dictionary<string, int> secondList = new Dictionary<string, int>();
        for(int i = 0; i < list2.Length; i++)
        {
            secondList.Add(list2[i], i);
        }
        int smallest = 2001;
        List<string> smallestWords = new List<string>();
        for(int i = 0; i < list1.Length; i++)
        {
            if(secondList.ContainsKey(list1[i]) == false)
                continue;
            if(i+secondList[list1[i]] < smallest)
            {
                smallestWords = new List<string>();
                smallest = i + secondList[list1[i]];
                smallestWords.Add(list1[i]);
            }
            else if(i+secondList[list1[i]] == smallest)
                smallestWords.Add(list1[i]);
        }
        return smallestWords.ToArray();
    }
}