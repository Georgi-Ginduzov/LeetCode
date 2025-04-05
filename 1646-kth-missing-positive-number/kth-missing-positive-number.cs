public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        int low = 0;
		int high = arr.Length;
		while(low < high)
		{
            int mid = low + (high-low) / 2;
            if(arr[mid] - mid - 1 >= k)
                high = mid;
            else
                low = mid + 1;
		}

		return high + k;
    }
}