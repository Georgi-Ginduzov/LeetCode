public class Solution {
    public int MostWordsFound(string[] sentences) {
        var max = 0;
        foreach(var sentence in sentences)
        {
            var spaces = 0;
            foreach(var ch in sentence)
                if(ch == ' ')
                    spaces++;
            
            max = max > spaces ? max : spaces;
        }

        return max + 1;
    }
}