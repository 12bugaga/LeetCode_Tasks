public class Solution {
    public int ClimbStairs(int n) {
        
        if (n == 1)
            return 1;

        int prev = 1;
        int current = 1;

        for (int i = 2; i <= n; i++)
        {
            var t = current;
            current += prev;
            prev = t;
        }

        return current;
    }
}