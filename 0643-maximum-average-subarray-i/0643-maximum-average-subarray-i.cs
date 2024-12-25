public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        
        double max = 0;
        double sum = 0;
        for(int i = 0; i < k; i++)
            sum += nums[i];
        
        max = sum / k;
        for(int i = k; i < nums.Length; i++)
        {
            sum += nums[i] - nums[i-k];
            max = Math.Max(max, sum / k);
        }

        return max;
    }
}