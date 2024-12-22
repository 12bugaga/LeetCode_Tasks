public class Solution {
    public int[] SortArrayByParityII(int[] nums) {

        var even = 0;
        var odd = 1;
        var res = new int[nums.Length];

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] % 2 == 0)
            {
                res[even] = nums[i];
                even +=2;
            }
            else
            {
                res[odd] = nums[i];
                odd += 2;
            }
        }

        return res;
    }
}