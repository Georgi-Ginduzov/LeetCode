public class Solution {
    public int Tribonacci(int n) {
        switch(n)
        {
            case 0:
                return 0;
            case 1:
                return 1;
            case 2: 
                return 1;
        }

        int[] cache = new int[n+1];
        cache[0] = 0;
        cache[1] = 1;
        cache[2] = 1;

        int F(int n)
        {
            if(cache[n] == 0 && n != 0)
                cache[n] = F(n-3) + F(n-2) + F(n-1);
            
            return cache[n];
        }

        return F(n);
    }
}