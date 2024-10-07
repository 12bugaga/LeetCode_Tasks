public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> dict = new HashSet<int>();
        dict.Add(n);
        int value, digit, sum;

        while(true)
        {
            value = dict.LastOrDefault();
            sum = 0;
            while(value != 0)
            {
                digit = value % 10;
                value /= 10;
                sum += digit * digit;
            }
            if(sum == 1)
                return true;
            else if(dict.Contains(sum))
                return false;
            else
                dict.Add(sum);
        } 
    }
}