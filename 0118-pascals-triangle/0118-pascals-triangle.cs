public class Solution {
    public IList<IList<int>> Generate(int numRows) {
    
        var res = new List<IList<int>>();
        for(int i = 0; i < numRows; i++)
        {
            var level = new List<int>();

            for(int j = 0; j <= i; j++)
            {
                if(j == 0 || j == i)
                    level.Add(1);
                else
                    level.Add(res[i-1][j-1] + res[i - 1][j]);
            }

            res.Add(level);
        }

        return res;
    }
}