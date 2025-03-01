public class Solution {
    public int[] AnswerQueries(int[] nums, int[] queries) {
        Array.Sort(nums);

        int[] preCalculations = new int[nums.Length];
        int[] answer = new int[queries.Length];
        
        preCalculations[0] = nums[0];
        for(int i = 1; i < nums.Length; i++)
        {
            preCalculations[i] = preCalculations[i-1] + nums[i];
        }

        for(int i = 0; i < queries.Length; i++)
        {
            int low = 0;
            int high = preCalculations.Length-1;
            
            while(low <= high)
            {
                int mid = low + (high - low) / 2;
                
                if(preCalculations[mid] == queries[i])
                {
                    answer[i] = mid+ 1;
                    break;
                }
                else if(preCalculations[mid] < queries[i])
                {
                    answer[i] = mid+ 1;
                    low = answer[i];
                }
                else 
                {
                    high = mid - 1;
                }
            }
        }
        return answer;
    }
}