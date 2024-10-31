public class Solution {
    public string ReformatDate(string date) {
        StringBuilder transformed = new StringBuilder();
        transformed.Append(date[3] == ' ' ? date.Substring(8, 4) : date.Substring(9, 4));
        switch(date.Substring(date[3] == ' ' ? 4 : 5, 3))
        {
            case "Jan":
                transformed.Append("-01-");
                break;
            case "Feb":
                transformed.Append("-02-");
                break;
            case "Mar":
                transformed.Append("-03-");
                break;
            case "Apr":
                transformed.Append("-04-");
                break;
            case "May":
                transformed.Append("-05-");
                break;
            case "Jun":
                transformed.Append("-06-");
                break;
            case "Jul":
                transformed.Append("-07-");
                break;
            case "Aug":
                transformed.Append("-08-");
                break;
            case "Sep":
                transformed.Append("-09-");
                break;
            case "Oct":
                transformed.Append("-10-");
                break;
            case "Nov":
                transformed.Append("-11-");
                break;
            case "Dec":
                transformed.Append("-12-");
                break;
        }
        transformed.Append(date[3] == ' ' ? string.Concat("0" + date[0]) : date.Substring(0, 2));
        return transformed.ToString();
    }
}