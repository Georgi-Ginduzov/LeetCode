public class Solution {
    public string ConvertDateToBinary(string date) {
        return Convert.ToString(int.Parse(date.Substring(0, 4)), 2) + "-" + Convert.ToString(int.Parse(date.Substring(5, 2)), 2) + "-" + Convert.ToString(int.Parse(date.Substring(8, 2)), 2);
    }
}