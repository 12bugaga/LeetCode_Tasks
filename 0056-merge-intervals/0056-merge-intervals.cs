public class Solution {
    public int[][] Merge(int[][] intervals) {

        int len = intervals.Length;
        if(len == 0)
            return new int[0][];

        intervals = intervals.OrderBy(a => a[0]).ToArray();

        var res = new List<int[]>();
        res.Add(intervals[0]);
        int p = 0;
        for(int i = 1; i < len; i++)
        {
            if(res[p][1] >= intervals[i][0])
                res[p][1] = Math.Max(intervals[i][1], res[p][1]);
            else
            {
                p++;
                res.Add(intervals[i]);
            }
        }

        return res.ToArray();
    }
}