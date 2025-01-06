public class Solution {
    public int MaxSubArray(int[] nums) {

        int curr = 0;
        int res = nums[0];

        for(int i = 0; i < nums.Length; i++)
        {
            if(curr < 0)
                curr = 0;
                
            curr += nums[i];
            res = Math.Max(res, curr);
        }

        return res;
    }
}