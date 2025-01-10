public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        
        var res = 0;
        if (intervals.Length <= 1)
            return res;

        intervals = intervals.OrderBy(a => a[0]).ToArray();

        int last = intervals[0][1];

        for(int i = 1; i < intervals.Length; i++)
        {
            if (last > intervals[i][0])
            {   
                last = Math.Min(intervals[i][1], last);
                res++;
            }
            else
                last = intervals[i][1];
        }

        return res;
    }
}