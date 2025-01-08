public class Solution {
    public int FindMin(int[] nums) {

        int res = nums[0];
        int l = 0;
        int r = nums.Length - 1;
        int mid = 0;
        
        while(l <= r)
        {
            mid = (l + r) / 2;
            res = nums[mid];
            if(nums[mid] < nums[r])
                r = mid;
            else
                l = mid + 1;
        }

        return res;
    }
}