public class Solution {
    public int SpecialArray(int[] nums) {
        Array.Sort(nums);
        int smallest = 0;
        int biggest = nums.Length;
        int x = -1;
        while(smallest <= biggest)
        {
            int middle = smallest + (biggest - smallest) / 2;
            if(middle == 0 && nums[middle] == 0)
                return -1;

            int matching = CountNumbers(middle, nums);
            if(matching == middle)
                return matching;
            if(matching > middle)
            {
                smallest = middle + 1;
            }
            else
            {
                biggest = middle - 1;
            }
        }
        return x;
    }
    public int CountNumbers(int key, int[] nums)
    {
        int from = 0;
        int to = nums.Length - 1;
        int breakpoint = -1;
        while(from <= to)
        {
            int mid = from + (to - from) / 2;
            if(nums[mid] >= key)
            {
                breakpoint = mid;
                to = mid - 1;
            }
            else
            {
                from = mid+1;
            }
        }

        if(breakpoint != -1)
            return nums.Length - breakpoint;
        return breakpoint;
    }
}