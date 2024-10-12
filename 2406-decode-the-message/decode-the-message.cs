public class Solution {
    public string DecodeMessage(string key, string message) {
        Dictionary<char, char> table = new Dictionary<char, char>();
        table[' '] = ' ';
        int j = 97;
        for(int i = 0; i < key.Length; i++)
        {
            if(table.ContainsKey(key[i]) == false){
                table[key[i]] = (char)j++;
            }
        }
        char[] decoded = new char[message.Length];
        for(int i = 0; i < message.Length; i++)
        {
            decoded[i] = table[message[i]];
        }
        return new string(decoded);
    }
}