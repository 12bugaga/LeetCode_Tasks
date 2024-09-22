public class Solution {
    public int MaxProfit(int[] prices) {
        int min = prices[0];
        int res = 0;

        for(int i = 1; i < prices.Length; i++)
        {
            if(min > prices[i])
                min = prices[i];;
            
            if(res < prices[i] - min)
                res = prices[i] - min;
        }

        return res;
    }
}