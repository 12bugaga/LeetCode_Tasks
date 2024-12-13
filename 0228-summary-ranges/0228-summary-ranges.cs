public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> result = new List<string>();
        int start = 0, end = 0;

        if(nums.Length == 0) return result;

        for(int i = 1; i <= nums.Count() - 1; i++)
        {
            if(nums[i] - 1 == nums[i - 1])
                end += 1;
            else
            {
                AddToArray(result, nums[start], nums[end]);
                start = i;
                end = start;
            }
        }
        AddToArray(result, nums[start], nums[end]);

        return result;
    }

    public void AddToArray(IList<string> result, int start, int end)
    {
        string sb = ""; 
        if(start == end)
            sb += start;
        else
            sb += start.ToString() + "->" + end.ToString();

        result.Add(sb.ToString());
    }
}