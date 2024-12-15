public class Solution {
    public int DayOfYear(string date) {
        DateTime date1 = DateTime.Parse(date);
        DateTime date2 = new DateTime(date1.Year, 1, 1);
        return (date1 - date2).Days + 1;
    }
}