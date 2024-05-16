using System;

var result = new Solution().TwoSum(new int[] { 2, 7, 11, 15 }, 9);
Console.WriteLine($"[{string.Join(", ", result)}]");


public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new();
        for (int i = 0; i < nums.Length; ++i)
        {
            int num = nums[i];
            int diff = target - num;

            if (dict.TryGetValue(diff, out int index))
            {
                return new[] { index, diff };
            }

            if (!dict.ContainsKey(num))
            {
                dict.Add(num, i);
            }
        }

        return new int[2];
    }
}