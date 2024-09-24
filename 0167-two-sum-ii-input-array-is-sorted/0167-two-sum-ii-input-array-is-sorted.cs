public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] res = new int[2];

        for(int i = numbers.Length - 1; i >= 0; i--)
        {
            for(int j = 0; j < i; j++)
            {
                if(numbers[i] + numbers[j] > target)
                    break;
                
                if(numbers[i] + numbers[j] == target)
                {
                    res[0] = j + 1;
                    res[1] = i + 1;
                    return res;
                }
            }
        }

        return res;
    }
}