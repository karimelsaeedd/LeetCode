public class Solution {
    public int[] RunningSum(int[] nums) {

        int[] runnungSum = new int[nums.Length];

        int prevSum = 0; 

        for(int i = 0; i < nums.Length; i++)
        {
            prevSum = nums[i] + prevSum;

            runnungSum[i] = prevSum;
        }

        return runnungSum;
    }
}