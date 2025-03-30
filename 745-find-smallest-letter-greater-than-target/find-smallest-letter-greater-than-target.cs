public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        if(letters[letters.Length-1] <= target)
            return letters[0];
        
        int low = 0; 
        int high = letters.Length-1;
        while(low < high)
        {
            int mid = low + (high-low) / 2;
            if(letters[mid] > target)
                high = mid;
            else
                low = mid + 1;
        }
        return letters[high];
    }
}