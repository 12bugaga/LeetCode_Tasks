public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        bool toRight = true;
        bool toDown = false;
        bool toLeft = false;
        bool toUp = false;

        int row = 0;
        int col = 0;
        int rowAmount = matrix.Length;
        int colAmount = matrix[0].Length;

        var amount = rowAmount * colAmount;

        var res = new List<int>();

        while (toRight || toDown || toLeft || toUp)
        {
            res.Add(matrix[row][col]);
            matrix[row][col] = -101;
            amount--;
            if (amount == 0)
                break;

            if (toRight)
            {
                if(col + 1 < colAmount && matrix[row][col + 1] != -101)
                {
                    col++;
                    continue;
                }
                else
                {
                    toRight = false;
                    toDown = true;
                    row++;
                    continue;
                }
            }

            if (toDown)
            {
                if (row + 1 < rowAmount && matrix[row + 1][col] != -101)
                {
                    row++;
                    continue;
                }
                else
                {
                    toDown = false;
                    toLeft = true;
                    col--;
                    continue;
                }
            }

            if (toLeft)
            {
                if (col - 1 > -1 && matrix[row][col - 1] != -101)
                {
                    col--;
                    continue;
                }
                else
                {
                    toLeft = false;
                    toUp = true;
                    row--;
                    continue;
                }
            }

            if (toUp)
            {
                if(row - 1 > -1 && matrix[row - 1][col] != -101)
                {
                    row--;
                    continue;
                }
                else
                {
                    toUp = false;
                    toRight = true;
                    col++;
                    continue;
                }
            }
        }

        return res;
    }
}