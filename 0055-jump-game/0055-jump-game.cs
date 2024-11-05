public class Solution {
    public bool CanJump(int[] nums) {
        var index = nums.Length - 1;

        for(int i = index - 1; i >= 0; i--)
            if(i + nums[i] >= index)
                index = i;

        if(index == 0)
            return true;
        return false;
    }
}