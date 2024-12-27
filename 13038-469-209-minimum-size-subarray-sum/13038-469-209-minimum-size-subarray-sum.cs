public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        
        int res = Int32.MaxValue;
        int len = 0;
        int sum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            len++;

            while(sum >= target)
            {
                res = Math.Min(res, len);
                if(res == 1)
                    return res;

                sum -= nums[i - len + 1];
                len--;
            }
        }

        if(res == Int32.MaxValue)
            return 0;
            
        return res;
    }
}