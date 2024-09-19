public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0;
        for(int i = 0; i < nums.Length - k; i++)
        {
            if(nums[i] != val)
                continue;
                
            for(int j = nums.Length -1 - k; j >= i; j--)
            {
                if(nums[j] == val)
                    k++;
                else
                {
                    nums[i] = nums[j];
                    nums[j] = val;
                    k++;
                    break;
                }
            }
        }

        return nums.Length - k;
    }
}