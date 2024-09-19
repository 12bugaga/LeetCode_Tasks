public class Solution {
    public int MajorityElement(int[] nums) {
        int cand = 0;
        int count = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(count != 0)
                count += cand == nums[i] ? 1 : -1;
            else
            {
                cand = nums[i];
                count++;
            }
        }

        return cand;
    }
}