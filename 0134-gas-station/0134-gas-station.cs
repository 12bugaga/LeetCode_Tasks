public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {

        if(gas.Sum() < cost.Sum())
            return -1;

        int start = 0;
        int amount = 0;

        for (int i = 0; i < gas.Length; i++)
        {
            amount += gas[i] - cost[i];

            if(amount < 0)
            {
                start = i + 1;
                amount = 0;
            }
        }

        return start;
    }
}