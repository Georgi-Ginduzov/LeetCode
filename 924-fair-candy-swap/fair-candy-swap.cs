public class Solution {
    public int[] FairCandySwap(int[] aliceSizes, int[] bobSizes) {
        int aliceSum = aliceSizes.Sum(); 
        int bobSum = bobSizes.Sum(); 
        
        foreach(int aliceCandy in aliceSizes)
        {
            foreach(int bobCandy in bobSizes)
            {
                if(aliceSum-aliceCandy+bobCandy == bobSum-bobCandy+aliceCandy)
                    return new int[] {aliceCandy, bobCandy};
            }
        }
        return new int[2];
    }
}