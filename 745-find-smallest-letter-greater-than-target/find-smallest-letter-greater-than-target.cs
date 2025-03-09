public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        int low = 0;
        int high = letters.Length - 1;

        if(letters[high] <= target)
            return letters[0];
        while(low < high)
        {
            int mid = low + (high-low) /2;
            if(letters[mid] <= target)
            {
                low = mid+1;
            }
            else
            {
                high = mid;
            }
        }
        return letters[low];
    }
}