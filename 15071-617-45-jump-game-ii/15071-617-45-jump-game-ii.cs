public class Solution {
    public int Jump(int[] nums) {

        if(nums.Length <= 1)
            return 0;

        int current = 0;
        int right = 0;
        int step = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            right = Math.Max(right, nums[i] + i);
            if(i == current)
            {
                step++;
                current = right;
                if(current >= nums.Length - 1) 
                    break;
            }
        }

        return step;
    }
}