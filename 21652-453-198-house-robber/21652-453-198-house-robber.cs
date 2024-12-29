public class Solution {
    public int Rob(int[] nums) {

        if(nums.Length == 1)
            return nums[0];

        int prevp = 0;
        int prev = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            int temp = Math.Max(prevp + nums[i], prev);
            prevp = prev;
            prev = temp;
        }

        return prev;
    }
}