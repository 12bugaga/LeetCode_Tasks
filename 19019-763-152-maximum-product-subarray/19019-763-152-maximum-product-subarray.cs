public class Solution {
    public int MaxProduct(int[] nums) {
        
        int currMax = nums[0];
        int currMin = nums[0];
        int res = nums[0];
        
        for(int i = 1; i < nums.Length; i++)
        {
            var t = Math.Max(nums[i], Math.Max(nums[i] * currMax, nums[i] * currMin));

            currMin = Math.Min(nums[i], Math.Min(nums[i] * currMax, nums[i] * currMin));

            currMax = t;
            res = Math.Max(currMax, res);
        }

        return res;
    }
}