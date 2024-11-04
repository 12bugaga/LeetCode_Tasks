public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var res = new int[nums.Length];
        var factor = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            res[i] = factor;
            factor *= nums[i];
        }
        factor = 1;
        for(int i = nums.Length - 1; i >= 0; i--)
        {
            res[i] *= factor;
            factor *= nums[i];
        }

        return res;
    }
}