public class Solution {
    public int CountCharacters(string[] words, string chars) {
        int characters = 0;
        for(int i = 0; i < words.Length; i++)
        {
            StringBuilder allowed = new StringBuilder(chars);
            for(int j = 0; j < words[i].Length; j++)
            {
                int index = 0;
                while(index < allowed.Length && allowed[index] != words[i][j])
                {
                    index++;
                }
                if(index == allowed.Length)
                {
                    j = words[i].Length;
                }
                else
                {
                    allowed.Remove(index, 1);
                }
            }

            if(allowed.Length == chars.Length - words[i].Length)
            {
                characters += words[i].Length;
            }
        }
        return characters;
    }
}