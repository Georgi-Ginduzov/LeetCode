public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        Dictionary<char, int> alphabet = new Dictionary<char, int>();
        for(int i = 0; i < order.Length; i++)
        {
            alphabet.Add(order[i], i);
        }
        for(int i = 0; i < words.Length - 1; i++)
        {
            if(words[i][0] == words[i+1][0])
            {
                int j = 1; 
                if(words[i].Length <= words[i+1].Length)
                {
                    while(j < words[i].Length && words[i][j] == words[i+1][j])
                    {
                        j++;
                    }
                    if(j < words[i].Length && alphabet[words[i][j]] > alphabet[words[i+1][j]])
                        return false;
                }
                else
                {
                    while(j < words[i+1].Length && words[i][j] == words[i+1][j])
                    {
                        j++;
                    }
                    if(j == words[i+1].Length)
                        return false;
                }
            }
            else if(alphabet[words[i][0]] > alphabet[words[i+1][0]])
            {
                return false;
            }
        }
        return true;
    }
}