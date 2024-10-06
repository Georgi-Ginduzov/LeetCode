public class Solution {
    public string DefangIPaddr(string address) {
        StringBuilder defanged = new StringBuilder(address.Length + 6);
        foreach(var digit in address)
        {
            if(digit == '.')
            {
                defanged.Append("[.]");
                continue;
            }
            defanged.Append(digit);
        }
        return defanged.ToString();
    }
}