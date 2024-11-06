public class Solution {
    public bool IsCircularSentence(string sentence) {
        int spaces = 0;
        for(int i = 0; i < sentence.Length; i++)
        {
            if(sentence[i] == ' ')
            {
                spaces++;
                if(sentence[i-1] != sentence[i+1])
                    return false;
            }
        }
        return sentence[0] == sentence[sentence.Length - 1];
    }
}