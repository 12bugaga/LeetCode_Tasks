public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 1;
        int count = 1;
        
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[k-1])
            {
                if (count != 2)
                {
                    nums[k] = nums[i];
                    count++;
                    k++;
                }
            }
            else
            {
                nums[k] = nums[i];
                count = 1;
                k++;
            }
        }

        return k;
    }
}