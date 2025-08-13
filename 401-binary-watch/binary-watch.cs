public class Solution {
    public IList<string> ReadBinaryWatch(int turnedOn) {
        
        List<string> result = new List<string>();
        for(int h = 0; h < 12; h++)
        {
            for(int m = 0; m < 60; m++)
            {
                int d = 0;
                for(int a = 0; a < 6; a++)
                    d += (((h&(1<<a)) > 0)?1:0) + (((m&(1<<a)) > 0)?1:0);
                if(d == turnedOn)
                    result.Add(h.ToString() + ":" + m.ToString().PadLeft(2,'0'));
            }
        }
        return result;
    }
}