public class Solution {
    public int MaxProfit(int[] prices) {
        int res = 0;
        int buy = -1; 

        for (int i = 0; i < prices.Length - 1; i++)
        {
            if (prices[i] < prices[i + 1] && buy == -1)
                buy = prices[i];
            if ((prices[i] > prices[i + 1]) && buy != -1)
            {
                res += prices[i] - buy;
                buy = -1;
            }
        }

        if(buy != -1)
            res += prices[prices.Length - 1] - buy;

        return res;
    }
}